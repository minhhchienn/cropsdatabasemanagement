using System.Data;
using System.Data.SqlClient;


namespace QuanLyCSDLTrongTrot.Modules
{
    internal class SQLConnectionModule
    {
        readonly SqlConnection connection = new();

        public void CreateConnect()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=CSDLTrongTrot;Integrated Security=True";
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        public void CloseConnect()
        {
            connection.Close();
        }

        public DataTable LoadData(string sqlcmd)
        {
            DataTable dt = new();
            CreateConnect();
            SqlDataAdapter da = new(sqlcmd, connection);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        
        public bool CheckPassword(string username, string password)
        {
            CreateConnect();
            string sql = "SELECT dbo.CheckPassword(@USERNAME, @PASSWORD);";
            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            var result = (bool)cmd.ExecuteScalar();
            return result;
        }
    }
}
