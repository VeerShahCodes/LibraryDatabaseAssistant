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
    }
}
