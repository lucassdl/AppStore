using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LL.Store.Data.ADO
{
    public class LLStoreDataContextADO : IDisposable
    {
        private readonly SqlConnection _conn;

        public LLStoreDataContextADO()
        {
            var connString = ConfigurationManager.ConnectionStrings["StoreConn"].ConnectionString;

            _conn = new SqlConnection(connString);
            _conn.Open();
        }

        public void ExecuteCommand(string sql)
        {
            var command = new SqlCommand()
            {
                CommandText = sql,
                CommandType = CommandType.Text,
                Connection = _conn
            };

            command.ExecuteNonQuery();
        }
        
        public SqlDataReader ExecuteDataReder(string query)
        {
            var command = new SqlCommand()
            {
                CommandText = query,
                Connection = _conn
            };

            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (_conn.State == ConnectionState.Open)
                _conn.Close();
        }
    }
}
