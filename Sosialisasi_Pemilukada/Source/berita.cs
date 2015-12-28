using Sosialisasi_Pemilukada.Database;
using System.Data.SQLite;

namespace Sosialisasi_Pemilukada.Source
{
    public class berita
    {
        private db_connect connect;
        private string _query;

        public string nama { get; set; }
        public string headline { get; set; }
        public string url_video { get; set; }

        public berita()
        {
            _query = "";
            connect = new db_connect("database.db");
        }

        public void Showberita(int x)
        {
            connect.Open();

            _query = "SELECT * FROM berita_pilkada WHERE id = '" + x + "';";
            var command = new SQLiteCommand(_query, connect.Connect);
            var result = command.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    nama = result.GetString(1);
                    headline = result.GetString(2);
                    url_video = result.GetString(3);
                }
            }

            connect.Close();
        }
    }
}
