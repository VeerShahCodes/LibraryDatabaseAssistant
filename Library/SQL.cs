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
            result = null;
            connection.Open();
            try
            {
                result = cmd.ExecuteScalar();

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
            cmd.Parameters.AddWithValue("@location", location);

            bool success = ExecuteNonQuery(cmd);
            if (success)
            {
                GetLibraryID(location, out id);
            }

            return success;
        }

        public bool RegisterMember(string name, out object id)
        {
            id = -1;
            string query = "usp_RegisterMember";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@legalName", name);

            bool success = ExecuteNonQuery(cmd);
            if(success)
            {
                GetMemberID(name, out id);
            }

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
                DataTable table;
                GetLibraryBookInfo(library_id, book_id, out table);
                id = table.Rows[0][0];
                quantity = table.Rows[0][1];
                return true;
            }
            id = -1;
            quantity = -1;
            return false;
        }

        public bool GetLibraryBookInfo(int library_id, int book_id, out DataTable table)
        {
            string query = "usp_GetLibraryBookInfo";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@book_id", book_id);
            cmd.Parameters.AddWithValue("@library_id", library_id);

            return DataAdapter(cmd, out table);


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
            id = -1;
            string query = "usp_GetMemberId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@legalName", name);
            return ExecuteScalar(cmd, out id);
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

        public bool GetAvailableBooksByLibrary(int library_id, out List<int> ids)
        {
            ids = new List<int>();
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
                    ids.Add((int)table.Rows[i][0]);
                }
                return true;
            }
            return false;
        }
        public bool GetBookByID(int book_id, string title, string author, string genre)
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
            return false;
        }
        public void GetBooksByAuthorFromLibrary (string author, int library_id)
        {
            string query = "usp_GetBooksByAuthorFromLibrary";
            SqlCommand cmd = new SqlCommand(query, connection);

        }
        public void GetBooksByGenreFromLibrary () { }
        public void GetCheckedOutBooksByLibrary() { }
        public void GetCheckedOutBooksByMember() { }
        public bool GetLibrariesWithBook (int book_id, out List<int> ids) 
        {
            ids = new List<int>();
            string query = "usp_GetLibrariesWithBook";
            SqlCommand cmd = new SqlCommand(query, connection);
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
        public bool ReturnBook (int member_id, int book_id, int library_id, out int id, out int quantity) 
        {
            id = -1;
            quantity = -1;

            string query = "usp_ReturnBook";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@member_id", member_id);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            cmd.Parameters.AddWithValue("@library_id", library_id);

            bool success = ExecuteNonQuery(cmd);

            if(success)
            {
                DataTable table;
                GetLibraryBookInfo(library_id, book_id, out table);

                id = (int)table.Rows[0][0];
                quantity = (int)table.Rows[0][1];
                return true;
            }
            return false;
        }
    }
}
