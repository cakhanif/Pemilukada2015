using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Sosialisasi_Pemilukada.Process
{
    class json_berita
    {
        public string nama { get; set; }
        public string headline { get; set; }
        public string url_video { get; set; }

        public int error { get; set; }

        public async void generate_berita(int x)
        {
            var strAPI = "http://localhost/json/berita.php";
            var client = new HttpClient();

            Task<string> asyncData = client.GetStringAsync(strAPI);

            try
            {
                var jsonData = await asyncData;
                var parsed = JObject.Parse(jsonData);

                nama = (string)parsed["data"]["results"]["news"][x]["candidate"]["name"];
                headline = (string)parsed["data"]["results"]["news"][x]["description"];
                url_video = (string)parsed["data"]["results"]["news"][x]["link"];
            }
            catch (Exception ex)
            {
                error = 1;
                Console.WriteLine(ex);
            }
        }
    }
}
