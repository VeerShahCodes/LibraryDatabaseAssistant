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

        private bool DataAdapter(string query, out DataTable dataTable)
        {
            dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
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

            return DataAdapter(query, out table);


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

        public void GetAvailableBooksByLibrary(int library_id)
        {
            string query = "usp_GetAvailableBooksByLibrary";
            SqlCommand cmd = new SqlCommand(query, connection);

        }
        public void GetBooksByAuthorFromLibrary () { }
        public void GetBooksByGenreFromLibrary () { }
        public void GetCheckedOutBooksByLibrary() { }
        public void GetCheckedOutBooksByMember() { }
        public void GetLibrariesWithBook () { }
        public void GetMemberInfoByID () { }
        public void ReturnBook () { }
    }
}
