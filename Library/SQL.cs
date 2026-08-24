using Library.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
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

        public static string CreateMD5Hash(string input)
        {
            using (MD5 mD5 = MD5.Create())
            {
                byte[] rawData = Encoding.UTF8.GetBytes(input);

                byte[] data = mD5.ComputeHash(rawData);

                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        public static string MakeSalt()
        {
            var sb = new StringBuilder();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                sb.Append((char)random.Next(33, 126));
            }
            return sb.ToString();
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

        public bool AddBookToSystem(string title, string description, out object id)
        {
            id = -1;
            string cmdString = "usp_AddBook";
            SqlCommand cmd = new SqlCommand(cmdString, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Description", description);


            bool success = ExecuteNonQuery(cmd);
            if (success)
            {
                GetBookID(title, out id);
            }

            return success;

        }

        public bool RegisterNewLibrary(string location, out object id)
        {
            id = -1;
            string query = "usp_AddLibrary";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", location);
            bool success = ExecuteScalar(cmd, out id);
            id = Convert.ToInt32(id);
            return success;
        }

        public bool RegisterMember(string username, string password, byte memberType, out object id)
        {

            string salt = MakeSalt();
            string passwordHash = CreateMD5Hash(password + salt);

            id = -1;
            string query = "usp_SignUp";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
            cmd.Parameters.AddWithValue("@Salt", salt);
            cmd.Parameters.AddWithValue("@MemberType", memberType);
            bool success = ExecuteNonQuery(cmd);
            if (success)
            {
                GetMemberID(username, passwordHash, out id);
            }

            return success;

        }

        public bool AddBookToLibrary(int library_id, int book_id, int count, out object id, out object quantity)
        {
            string query = "usp_AddBooksToLibraries";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", book_id);
            cmd.Parameters.AddWithValue("@LibraryID", library_id);
            cmd.Parameters.AddWithValue("@Count", count);
            bool success = ExecuteNonQuery(cmd);

            if (success)
            {
                GetLibraryBookInfo(library_id, book_id, out BooksToLibraries book);
                id = book.BookID;
                quantity = book.Count;
                return true;
            }
            id = -1;
            quantity = -1;
            return false;
        }

        public bool GetLibraryBookInfo(int library_id, int book_id, out BooksToLibraries book)
        {
            string query = "usp_GetBooksToLibrariesInfo";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", book_id);
            cmd.Parameters.AddWithValue("@LibraryID", library_id);

            if (DataAdapter(cmd, out DataTable table))
            {
                book = new BooksToLibraries((int)table.Rows[0][0], (int)table.Rows[0][1], (int)table.Rows[0][2], (int)table.Rows[0][3]);
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
            cmd.Parameters.AddWithValue("@LibraryID", library_id);
            cmd.Parameters.AddWithValue("@BookID", book_id);
            cmd.Parameters.AddWithValue("@MemberID", member_id);
            cmd.Parameters.AddWithValue("@TimeOfCheckout", toc);

            return ExecuteScalar(cmd, out id);
        }

        public bool CheckoutBook(int book_id, int library_id, int member_id, out object id)
        {
            DateTime now = DateTime.Now;
            string query = "usp_AddBooksToMembers";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MemberID", member_id);
            cmd.Parameters.AddWithValue("@BookID", book_id);
            cmd.Parameters.AddWithValue("@LibraryID", library_id);
            cmd.Parameters.AddWithValue("@TimeOfCheckout", now);
            cmd.Parameters.AddWithValue("@TimeOfReturn", now.AddDays(7));
            bool success = ExecuteNonQuery(cmd);
            if (success)
            {
                GetMemberLibraryBookID(library_id, book_id, member_id, now, out id);
                return true;
            }
            id = -1;
            return success;
        }
        public bool GetMemberID(string name, string passwordHash, out object id)
        {

            string query = "usp_GetMemberID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", name);
            cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
            bool success = ExecuteScalar(cmd, out id);
            return success;
        }

        public bool GetBookID(string title, out object id)
        {
            id = -1;
            string query = "usp_GetBookID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", title);
            return ExecuteScalar(cmd, out id);
        }

        public bool GetLibraryID(string location, out object id)
        {
            id = -1;
            string query = "usp_GetLibraryID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", location);
            return ExecuteScalar(cmd, out id);
        }

        public bool AddAuthor(string name, out object id)
        {
            id = -1;
            string query = "usp_AddAuthor";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            bool success = ExecuteNonQuery(cmd);
            if(success)
            {
                GetAuthorID(name, out id);
            }

            return success;
        }

        public bool GetAuthorID(string name, out object id)
        {
            id = -1;
            string query = "usp_GetAuthorID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            bool success = ExecuteScalar(cmd, out id);
            return success;
        }

        public bool AddGenre(string name, out object id)
        {
            id = -1;
            string query = "usp_AddGenre";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            bool success = ExecuteNonQuery(cmd);
            if(success)
            {
                GetGenreID(name, out id);
            }
            return success;
        }

        public bool GetGenreID(string name, out object id)
        {
            id = -1;
            string query = "usp_GetGenreID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            bool success = ExecuteScalar(cmd, out id);
            return success;
        }

        public bool AddBooksToAuthors(int bookId, int authorId, out object id)
        {
            id = -1;
            string query = "usp_AddBooksToAuthors";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", bookId);
            cmd.Parameters.AddWithValue("@AuthorID", authorId);
            bool success = ExecuteNonQuery(cmd);
            if(success)
            {
                GetBTAID(bookId, authorId, out id);
            }

            return success;
        }

        public bool GetBTAID(int bookId, int authorId, out object id)
        {
            id = -1;
            string query = "usp_GETBTAID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", bookId);
            cmd.Parameters.AddWithValue("@AuthorID", authorId);
            bool success = ExecuteScalar(cmd, out id);
            return success;
        }

        public bool AddBooksToGenres(int bookId, int genreId, out object id)
        {
            id = -1;
            string query = "usp_AddBooksToGenres";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", bookId);
            cmd.Parameters.AddWithValue("@GenreID", genreId);
            bool success = ExecuteNonQuery(cmd);
            if (success)
            {
                GetBTAID(bookId, genreId, out id);
            }

            return success;
        }

        public bool GetBTGID(int bookId, int genreId, out object id)
        {
            id = -1;
            string query = "usp_GETBTGID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", bookId);
            cmd.Parameters.AddWithValue("@GenreID", genreId);
            bool success = ExecuteScalar(cmd, out id);
            return success;
        }

        public bool AddSeries(string name, out object id)
        {
            id = -1;
            string query = "usp_AddSeries";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            bool success = ExecuteNonQuery(cmd);
            if(success)
            {
                GetSeriesID(name, out id);
            }
            return success;

        }

        public bool GetSeriesID(string name, out object id)
        {
            id = -1;
            string query = "usp_GetSeriesID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            bool success = ExecuteScalar(cmd, out id);
            return success;
        }

        public bool AddBooksToSeries(int BookID, int SeriesID, out object id)
        {
            id = -1;
            string query = "usp_AddBooksToSeries";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", BookID);
            cmd.Parameters.AddWithValue("@SeriesID", SeriesID);
            bool success = ExecuteNonQuery(cmd);
            if (success)
            {
                GetBTSID(BookID, SeriesID, out id);
            }

            return success;
        }

        public bool GetBTSID(int bookId, int seriesId, out object id)
        {
            id = -1;
            string query = "usp_GETBTSID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", bookId);
            cmd.Parameters.AddWithValue("@SeriesID", seriesId);
            bool success = ExecuteScalar(cmd, out id);
            return success;
        }

        public bool Login(string username, string password, out object id)
        {
            string salt;
            GetSalt(username, out salt);

            string passwordHash = CreateMD5Hash(password + salt);

            string query = "usp_Login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
            bool success = ExecuteScalar(cmd, out id);
            if(success)
            {
                if (id != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public bool GetSalt(string username, out string salt)
        {
            salt = "";
            string query = "usp_GetSalt";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username);
            object saltObj;
            bool success = ExecuteScalar(cmd, out saltObj);
            salt = saltObj.ToString();
            return success;
        }
        //public List<LibraryBook> GetAvailableBooksByLibrary(int library_id)
        //{
        //    List<LibraryBook> books = new List<LibraryBook>();
        //    string query = "usp_GetAvailableBooksByLibrary";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@library_id", library_id);
        //    DataTable table;
        //    bool success = DataAdapter(cmd, out table);
        //    if(success)
        //    {
        //        for(int i = 0; i <  table.Rows.Count; i++)
        //        {
        //            books.Add(new LibraryBook((int)table.Rows[i][0], (int)table.Rows[i][1], (int)table.Rows[i][2], (int)table.Rows[i][3]));
        //        }
        //    }
        //    return books;
        //}
        //public bool GetBookByID(int book_id, out string title, out string author, out string genre)
        //{
        //    string query = "usp_GetBookByID";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@book_id", book_id);

        //    DataTable table;
        //    bool success = DataAdapter(cmd, out table);

        //    if(success)
        //    {
        //        title = (string)table.Rows[0][0];
        //        author = (string)table.Rows[0][1];
        //        genre = (string)table.Rows[0][2];
        //        return true;
        //    }
        //    title = "";
        //    author = "";
        //    genre = "";
        //    return false;
        //}
        //public bool GetBooksByAuthorFromLibrary (string author, int library_id, out List<int> ids)
        //{
        //    ids = new List<int>();
        //    string query = "usp_GetBooksByAuthorFromLibrary";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@author", author);
        //    cmd.Parameters.AddWithValue("@library_id", library_id);
        //    DataTable table;
        //    bool success = DataAdapter(cmd, out table);

        //    if(success)
        //    {
        //        for(int i = 0; i < table.Rows.Count; i++)
        //        {
        //            ids.Add((int)table.Rows[i][0]);
        //        }
                
        //    }
        //    return success;

        //}
        //public bool GetBooksByGenreFromLibrary (string genre, int library_id, out List<int> ids) 
        //{
        //    ids = new List<int>();
        //    string query = "usp_GetBooksByGenreFromLibrary";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@genre", genre);
        //    cmd.Parameters.AddWithValue("@library_id", library_id);
        //    DataTable table;
        //    bool success = DataAdapter(cmd, out table);

        //    if(success)
        //    {
        //        for(int i = 0; i < table.Rows.Count;i++)
        //        {
        //            ids.Add((int)table.Rows[i][0]);
        //        }
        //    }
        //    return success;
        //}
        //public List<MemberLibraryBook> GetCheckedOutBooksByLibrary(int library_id) 
        //{
        //    List<MemberLibraryBook> list = new List<MemberLibraryBook>();

        //    string query = "usp_GetCheckedOutBooksByLibrary";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType= CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@library_id", library_id);

        //    DataTable table;
        //    bool success = DataAdapter(cmd, out table);

        //    if (success)
        //    {
        //        for (int i = 0; i < table.Rows.Count; i++)
        //        {
        //            list.Add(new MemberLibraryBook((int)table.Rows[i][0], (int)table.Rows[i][1], (int)table.Rows[i][2], (int)table.Rows[i][3], (DateTime)table.Rows[i][4]));
        //        }
        //    }
        //    return list;
        //}
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
        //public bool GetMemberInfoByID (int id, out string legalName)
        //{
        //    string query = "usp_GetMemberInfoByID";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@member_id", id);
        //    object val;
        //    bool success = ExecuteScalar(cmd, out val);
        //    if(success)
        //    {
        //        legalName = (string)val;
        //        return true;
        //    }
        //    legalName = "";
        //    return false;

        //}

        //public List<Member> GetMembers()
        //{
        //    List<Member> list = new List<Member>();
        //    string query = "usp_GetMembers";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    DataTable table;
        //    bool success = DataAdapter(cmd, out table);

        //    for(int i = 0; i < table.Rows.Count; i++)
        //    {
        //        list.Add(new Member((int)table.Rows[i][0], (string)table.Rows[i][1]));
        //    }

        //    return list;
        //}
        
        //public bool ReturnBook (int member_id, int book_id, int library_id, int mlbId, out int id, out int quantity) 
        //{
        //    id = -1;
        //    quantity = -1;

        //    string query = "usp_ReturnBook";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@member_id", member_id);
        //    cmd.Parameters.AddWithValue("@book_id", book_id);
        //    cmd.Parameters.AddWithValue("@library_id", library_id);
        //    cmd.Parameters.AddWithValue("@checkedOutBook_id", mlbId);
        //    bool success = ExecuteNonQuery(cmd);

        //    if(success)
        //    {
        //        GetLibraryBookInfo(library_id, book_id, out LibraryBook book);

        //        id = book.id;
        //        quantity = book.quantity;
        //        return true;
        //    }
        //    return false;
        //}

        //public List<Book> GetBooks()
        //{
        //    List<Book> books = new List<Book>();
        //    string query = "usp_GetBooks";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    DataTable table;
        //    DataAdapter(cmd, out table);

        //    for(int i = 0; i < table.Rows.Count; i++)
        //    {
        //        books.Add(new Book((int)table.Rows[i][0], (string)table.Rows[i][1], (string)table.Rows[i][2], (string)table.Rows[i][3]));
        //    }

        //    return books;
        //}

        //public List<MemberLibraryBook> GetCheckedOutBooksByMember(int member_id)
        //{
        //    List<MemberLibraryBook> books = new List<MemberLibraryBook>();
        //    string query = "usp_GetCheckedOutBooksByMember";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@member_id", member_id);
        //    DataTable table;
        //    DataAdapter(cmd, out table);
        //    for(int i = 0; i < table.Rows.Count; i++)
        //    {
        //        MemberLibraryBook book = new MemberLibraryBook((int)table.Rows[i][0], (int)table.Rows[i][1], (int)table.Rows[i][2], (int)table.Rows[i][3], (DateTime)table.Rows[i][4]);
        //        books.Add(book);
        //    }

        //    return books;
        //}
    }
}
