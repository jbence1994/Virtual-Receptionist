using System.Data;
using MySql.Data.MySqlClient;

namespace VirtualReceptionist.Desktop.Repositories.MySQLConnection
{
    public sealed class Database
    {
        private static Database _databaseInstance;
        private MySqlConnection _mySqlConnection;
        private MySqlCommand _mySqlCommand;
        private MySqlDataAdapter _mySqlDataAdapter;

        private Database()
        {
        }

        public static Database GetDatabaseInstance()
        {
            if (_databaseInstance == null)
            {
                return _databaseInstance = new Database();
            }

            return _databaseInstance;
        }

        public void SetConnection()
        {
            _mySqlConnection = new MySqlConnection
            {
                ConnectionString =
                    "SERVER=127.0.0.1; DATABASE=virtual_receptionist; UID=root; PASSWORD=mySQLserver!12345; PORT=3306; SslMode=None;"
            };
        }

        private void OpenConnection()
        {
            if (_mySqlConnection.State != ConnectionState.Closed)
            {
                return;
            }

            _mySqlConnection.Open();
        }

        private void CloseConnection()
        {
            if (_mySqlConnection.State != ConnectionState.Open)
            {
                return;
            }

            _mySqlConnection.Close();
        }

        public DataTable Dql(string query)
        {
            OpenConnection();

            var dataTable = new DataTable();

            _mySqlCommand = new MySqlCommand
            {
                CommandText = query,
                Connection = _mySqlConnection
            };

            _mySqlDataAdapter = new MySqlDataAdapter
            {
                SelectCommand = _mySqlCommand
            };

            _mySqlDataAdapter.Fill(dataTable);

            CloseConnection();

            return dataTable;
        }

        public void Dml(string query)
        {
            OpenConnection();

            _mySqlCommand = new MySqlCommand
            {
                CommandText = query,
                Connection = _mySqlConnection
            };

            _mySqlCommand.Prepare();
            _mySqlCommand.ExecuteNonQuery();

            CloseConnection();
        }

        public string ScalarDql(string query)
        {
            OpenConnection();

            _mySqlCommand = new MySqlCommand
            {
                CommandText = query,
                Connection = _mySqlConnection
            };

            _mySqlCommand.Prepare();

            var scalarQuery = _mySqlCommand.ExecuteScalar().ToString();

            CloseConnection();

            return scalarQuery;
        }
    }
}
