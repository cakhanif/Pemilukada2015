using Sosialisasi_Pemilukada.Database;
using System.Data.SQLite;

namespace Sosialisasi_Pemilukada.Source
{
    class candidat
    {
        private db_connect connect;
        private string _query;

        public string provinsi { get; set; }
        public string daerah { get; set; }
        public string calon { get; set; }
        public string wakil { get; set; }

        public candidat()
        {
            _query = "";
            connect = new db_connect("database.db");
        }

        public void Showcandidat(int x)
        {
            connect.Open();

            _query = "SELECT * FROM candidates WHERE id = '" + x + "';";
            var command = new SQLiteCommand(_query, connect.Connect);
            var result = command.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    provinsi = result.GetString(1);
                    calon = result.GetString(4);
                    wakil = result.GetString(5);
                }
            }
        }
    }
}
