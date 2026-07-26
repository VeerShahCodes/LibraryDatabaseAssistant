using Library.Models;
using Microsoft.Data.SqlClient;
using System.Data;
namespace Library
{
    public class SQL
    {
        string ConnectionString { get; set; }
        SqlConnection connection;
        public SQL(string connectionString)
        {
            ConnectionString = connectionString;
            connection = new SqlConnection(ConnectionString);
        }

        private bool ExecuteNonQuery(SqlCommand command)
        {
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private bool ExecuteScalar(SqlCommand cmd, out object result)
        {
      
            connection.Open();
            try
            {
                result = cmd.ExecuteScalar();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
                result = null;
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private bool DataAdapter(SqlCommand cmd, out DataTable dataTable)
        {
            dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
                return false;
            }


        }

        public bool AddBookToSystem(string title, string author, string genre, out object id)
        {
            id = -1;
            string cmdString = "usp_AddBookToSystem";
            SqlCommand cmd = new SqlCommand(cmdString, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@genre", genre);

            bool success = ExecuteNonQuery(cmd);
            if (success)
            {
                GetBookID(title, author, genre, out id);
            }

            return success;

        }

        public bool RegisterNewLibrary(string location, out object id)
        {
            id = -1;
            string query = "usp_RegisterNewLibrary";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@locationName", location);

            bool success = ExecuteScalar(cmd, out id);
            id = Convert.ToInt32(id);

            return success;
        }

        public bool RegisterMember(string name, out object id)
        {
            id = -1;
            string query = "usp_RegisterMember";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);

            bool success = ExecuteScalar(cmd, out id);
            id = Convert.ToInt32(id);
            return success;

        }

        public bool AddBookToLibrary(int library_id, int book_id, out object id, out object quantity)
        {
            string query = "usp_AddBookToLibrary";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@book_id", book_id);
            cmd.Parameters.AddWithValue("@library_id", library_id);

            bool success = ExecuteNonQuery(cmd);

            if(success)
            {
                GetLibraryBookInfo(library_id, book_id, out LibraryBook book);
                id = book.id;
                quantity = book.quantity;
                return true;
            }
            id = -1;
            quantity = -1;
            return false;
        }

        public bool GetLibraryBookInfo(int library_id, int book_id, out LibraryBook book)
        {
            string query = "usp_GetLibraryBookInfo";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@book_id", book_id);
            cmd.Parameters.AddWithValue("@library_id", library_id);

            if(DataAdapter(cmd, out DataTable table))
            {
                book = new LibraryBook((int)table.Rows[0][0], library_id, book_id, (int)table.Rows[0][1]);
                return true;
            }
            book = null;
            return false;


        }

        public List<Models.Library> GetLibraries()
        {
            List<Models.Library> libraries = new List<Models.Library>();
            string query = "usp_GetLibraries";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            bool success = DataAdapter(cmd, out DataTable table);
            if(success)
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    libraries.Add(new Models.Library((int)table.Rows[i][0], (string)table.Rows[i][1]));
                }
            }

            return libraries;
        }
        


        public bool GetMemberLibraryBookID(int library_id, int book_id, int member_id, DateTime toc, out object id)
        {
            string query = "usp_GetMemberLibraryBookID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@library_id", library_id);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            cmd.Parameters.AddWithValue("@member_id", member_id);
            cmd.Parameters.AddWithValue("@time_of_checkout", toc);

            return ExecuteScalar(cmd, out id);
        }

        public bool CheckoutBook(int book_id, int library_id, int member_id, out object id)
        {
            DateTime now = DateTime.Now;
            string query = "usp_CheckoutBook";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@member_id", member_id);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            cmd.Parameters.AddWithValue("@library_id", library_id);
            cmd.Parameters.AddWithValue("@time_of_checkout", now);

            bool success = ExecuteNonQuery(cmd);
            if(success)
            {
                GetMemberLibraryBookID(library_id, book_id, member_id, now, out id);
                return true;
            }
            id = -1;
            return success;
        }
        public bool GetMemberID(string name, out object id)
        {
            
            string query = "usp_GetMemberId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@legalName", name);
            bool success = ExecuteScalar(cmd, out id);
            return success;
        }

        public bool GetBookID(string title, string author, string genre, out object id)
        {
            id = -1;
            string query = "usp_GetBookID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@genre", genre);
            return ExecuteScalar(cmd, out id);
        }

        public bool GetLibraryID(string location, out object id)
        {
            id = -1;
            string query = "usp_GetLibraryID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@location", location);
            return ExecuteScalar(cmd, out id);
        }

        public List<LibraryBook> GetAvailableBooksByLibrary(int library_id)
        {
            List<LibraryBook> books = new List<LibraryBook>();
            string query = "usp_GetAvailableBooksByLibrary";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@library_id", library_id);
            DataTable table;
            bool success = DataAdapter(cmd, out table);
            if(success)
            {
                for(int i = 0; i <  table.Rows.Count; i++)
                {
                    books.Add(new LibraryBook((int)table.Rows[i][0], (int)table.Rows[i][1], (int)table.Rows[i][2], (int)table.Rows[i][3]));
                }
            }
            return books;
        }
        public bool GetBookByID(int book_id, out string title, out string author, out string genre)
        {
            string query = "usp_GetBookByID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@book_id", book_id);

            DataTable table;
            bool success = DataAdapter(cmd, out table);

            if(success)
            {
                title = (string)table.Rows[0][0];
                author = (string)table.Rows[0][1];
                genre = (string)table.Rows[0][2];
                return true;
            }
            title = "";
            author = "";
            genre = "";
            return false;
        }
        public bool GetBooksByAuthorFromLibrary (string author, int library_id, out List<int> ids)
        {
            ids = new List<int>();
            string query = "usp_GetBooksByAuthorFromLibrary";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@library_id", library_id);
            DataTable table;
            bool success = DataAdapter(cmd, out table);

            if(success)
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    ids.Add((int)table.Rows[i][0]);
                }
                
            }
            return success;

        }
        public bool GetBooksByGenreFromLibrary (string genre, int library_id, out List<int> ids) 
        {
            ids = new List<int>();
            string query = "usp_GetBooksByGenreFromLibrary";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.Parameters.AddWithValue("@library_id", library_id);
            DataTable table;
            bool success = DataAdapter(cmd, out table);

            if(success)
            {
                for(int i = 0; i < table.Rows.Count;i++)
                {
                    ids.Add((int)table.Rows[i][0]);
                }
            }
            return success;
        }
        public List<MemberLibraryBook> GetCheckedOutBooksByLibrary(int library_id) 
        {
            List<MemberLibraryBook> list = new List<MemberLibraryBook>();

            string query = "usp_GetCheckedOutBooksByLibrary";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@library_id", library_id);

            DataTable table;
            bool success = DataAdapter(cmd, out table);

            if (success)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    list.Add(new MemberLibraryBook((int)table.Rows[i][0], (int)table.Rows[i][1], (int)table.Rows[i][2], (int)table.Rows[i][3], (DateTime)table.Rows[i][4]));
                }
            }
            return list;
        }
        public bool GetLibrariesWithBook (int book_id, out List<int> ids) 
        {
            ids = new List<int>();
            string query = "usp_GetLibrariesWithBook";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@book_id", book_id);

            bool success = DataAdapter(cmd, out DataTable table);
            if(success)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    ids.Add((int)table.Rows[i][0]);
                }
                
            }
            return success;
        }

        public bool GetLibraryByID(int library_id, out string name)
        {
            string query = "usp_GetLibraryByID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@library_id", library_id);
            object val;
            bool success = ExecuteScalar(cmd, out val);
            name = (string)val;
            return success;
        }
        public bool GetMemberInfoByID (int id, out string legalName)
        {
            string query = "usp_GetMemberInfoByID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@member_id", id);
            object val;
            bool success = ExecuteScalar(cmd, out val);
            if(success)
            {
                legalName = (string)val;
                return true;
            }
            legalName = "";
            return false;

        }

        public List<Member> GetMembers()
        {
            List<Member> list = new List<Member>();
            string query = "usp_GetMembers";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable table;
            bool success = DataAdapter(cmd, out table);

            for(int i = 0; i < table.Rows.Count; i++)
            {
                list.Add(new Member((int)table.Rows[i][0], (string)table.Rows[i][1]));
            }

            return list;
        }
        
        public bool ReturnBook (int member_id, int book_id, int library_id, int mlbId, out int id, out int quantity) 
        {
            id = -1;
            quantity = -1;

            string query = "usp_ReturnBook";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@member_id", member_id);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            cmd.Parameters.AddWithValue("@library_id", library_id);
            cmd.Parameters.AddWithValue("@checkedOutBook_id", mlbId);
            bool success = ExecuteNonQuery(cmd);

            if(success)
            {
                GetLibraryBookInfo(library_id, book_id, out LibraryBook book);

                id = book.id;
                quantity = book.quantity;
                return true;
            }
            return false;
        }

        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            string query = "usp_GetBooks";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable table;
            DataAdapter(cmd, out table);

            for(int i = 0; i < table.Rows.Count; i++)
            {
                books.Add(new Book((int)table.Rows[i][0], (string)table.Rows[i][1], (string)table.Rows[i][2], (string)table.Rows[i][3]));
            }

            return books;
        }

        public List<MemberLibraryBook> GetCheckedOutBooksByMember(int member_id)
        {
            List<MemberLibraryBook> books = new List<MemberLibraryBook>();
            string query = "usp_GetCheckedOutBooksByMember";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@member_id", member_id);
            DataTable table;
            DataAdapter(cmd, out table);
            for(int i = 0; i < table.Rows.Count; i++)
            {
                MemberLibraryBook book = new MemberLibraryBook((int)table.Rows[i][0], (int)table.Rows[i][1], (int)table.Rows[i][2], (int)table.Rows[i][3], (DateTime)table.Rows[i][4]);
                books.Add(book);
            }

            return books;
        }
    }
}
