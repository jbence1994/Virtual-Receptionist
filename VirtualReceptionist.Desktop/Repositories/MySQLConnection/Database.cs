using System.Data;
using MySql.Data.MySqlClient;

namespace VirtualReceptionist.Desktop.Repositories.MySQLConnection
{
    public sealed class Database
    {
        private static Database _instance;
        private MySqlConnection mySqlConnection;
        private MySqlCommand mySqlCommand;
        private MySqlDataAdapter mySqlDataAdapter;

        private Database()
        {
        }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                return _instance = new Database();
            }

            return _instance;
        }

        public void SetConnection()
        {
            mySqlConnection = new MySqlConnection
            {
                ConnectionString =
                    "SERVER=127.0.0.1; DATABASE=virtual_receptionist; UID=root; PASSWORD=mySQLserver!12345; PORT=3306; SslMode=None;"
            };
        }

        private void OpenConnection()
        {
            if (mySqlConnection.State != ConnectionState.Closed)
            {
                return;
            }

            mySqlConnection.Open();
        }

        private void CloseConnection()
        {
            if (mySqlConnection.State != ConnectionState.Open)
            {
                return;
            }

            mySqlConnection.Close();
        }

        public DataTable Dql(string query)
        {
            OpenConnection();

            var dataTable = new DataTable();

            mySqlCommand = new MySqlCommand
            {
                CommandText = query,
                Connection = mySqlConnection
            };

            mySqlDataAdapter = new MySqlDataAdapter
            {
                SelectCommand = mySqlCommand
            };

            mySqlDataAdapter.Fill(dataTable);

            CloseConnection();

            return dataTable;
        }

        public void Dml(string query)
        {
            OpenConnection();

            mySqlCommand = new MySqlCommand
            {
                CommandText = query,
                Connection = mySqlConnection
            };

            mySqlCommand.Prepare();
            mySqlCommand.ExecuteNonQuery();

            CloseConnection();
        }

        public string ScalarDql(string query)
        {
            OpenConnection();

            mySqlCommand = new MySqlCommand
            {
                CommandText = query,
                Connection = mySqlConnection
            };

            mySqlCommand.Prepare();

            var scalarQuery = mySqlCommand.ExecuteScalar().ToString();

            CloseConnection();

            return scalarQuery;
        }
    }
}
