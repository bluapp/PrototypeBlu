using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace API.Models
{
    public class DAL
    {
        private static string server = "blu.conc3xc22xi8.us-east-1.rds.amazonaws.com";
        private static string database = "bludev";
        private static string user = "dev";
        private static string password = "Blu.102030";
        private string connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; SslMode = none", server, user, password, database);

        private MySqlConnection connection;

        public DAL()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public void ExecutarComandoSQL(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, connection);
            comando.ExecuteNonQuery();
        }
        public DataTable RetDataTable(string sql)
        {
            DataTable data = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            data = new DataTable();
            da = new MySqlDataAdapter(sql, connection);
            da.Fill(data);
            return data;
        }
        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, connection);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            return dr;
        }

        public void FecharConexao()
        {
            connection.Close();
        }
    }
}
