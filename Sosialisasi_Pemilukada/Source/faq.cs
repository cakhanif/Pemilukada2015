using Sosialisasi_Pemilukada.Database;
using System.Data.SQLite;
using System;

namespace Sosialisasi_Pemilukada.Source
{
    class faq
    {
        private db_connect connect;
        private string _query;

        public string pertanyaan { get; set; }
        public string pasal { get; set; }
        public string isi_pasal { get; set; }
        public string jawab { get; set; }

        public faq()
        {
            _query = "";
            connect = new db_connect("database.db");
        }

        public void Showfaq(int x)
        {
            connect.Open();

            _query = "SELECT * FROM faq WHERE id = '" + x + "';";
            var command = new SQLiteCommand(_query, connect.Connect);
            var result = command.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    pertanyaan = result.GetString(1);
                    pasal = result.GetString(2);
                    isi_pasal = result.GetString(3);
                    jawab = result.GetString(4);
                }
            }

            connect.Close();
        }
    }
}
