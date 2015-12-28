using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Sosialisasi_Pemilukada.Process
{
    class json_candidat
    {
        public string provinsi { get; set; }
        public string daerah { get; set; }
        public string calon { get; set; }
        public string wakil { get; set; }

        public int error { get; set; }

        public async void generate_candidat(int x)
        {
            var strAPI = "http://localhost/json/candidat.php";
            var client = new HttpClient();

            Task<string> asyncData = client.GetStringAsync(strAPI);

            try
            {
                var jsonData = await asyncData;
                var parsed = JObject.Parse(jsonData);

                provinsi = (string)parsed["data"]["results"]["candidates"][x]["provinsi"]["nama"];
                daerah = (string)parsed["data"]["results"]["candidates"][x]["daerah"]["nama"];
                calon = (string)parsed["data"]["results"]["candidates"][x]["paslon"][0]["nama"];
                wakil = (string)parsed["data"]["results"]["candidates"][x]["paslon"][1]["nama"];
            }
            catch (Exception ex)
            {
                error = 1;
                Console.WriteLine("============EROR==========");
                Console.WriteLine(ex);
            }
        }
    }
}
