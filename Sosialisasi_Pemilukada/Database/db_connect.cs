using System.Data.SQLite;

namespace Sosialisasi_Pemilukada.Database
{
    public class db_connect
    {
        private SQLiteConnection _connect;
        private string _dbname;
        private string _path;

        public SQLiteConnection Connect
        {
            get
            {
                return _connect;
            }
        }

        public db_connect(string dbname, string path = null)
        {
            _connect = new SQLiteConnection();
            _dbname = dbname;
            _path = path ?? "";
        }

        public void Open()
        {
            _connect.ConnectionString = "Data Source=" + _path + _dbname + ";Version=3;";
            _connect.Open();
        }

        public void Close()
        {
            _connect.Close();
        }
    }
}
