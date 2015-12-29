using Sosialisasi_Pemilukada.Database;
using System.Data.SQLite;
using System.Drawing;
using System.Data;
using System.IO;

namespace Sosialisasi_Pemilukada.Source
{
    class gambar_load
    {
        private db_connect connect;
        private string _query;

        public Image gambar { get; set; }

        public gambar_load()
        {
            _query = "";
            connect = new db_connect("database.db");
        }

        public void ShowImage(int x)
        {
            connect.Open();

            _query = "select gambar from candidates where id = '" + x + "'";
            var command = new SQLiteCommand(_query, connect.Connect);
            command.ExecuteNonQuery();

            SQLiteDataAdapter data = new SQLiteDataAdapter(command);
            DataTable da = new DataTable();

            data.Fill(da);
            byte[] img = (byte[])da.Rows[0][0];

            MemoryStream convert = new MemoryStream(img);
            gambar = Image.FromStream(convert);

            connect.Close();
        }
    }
}
