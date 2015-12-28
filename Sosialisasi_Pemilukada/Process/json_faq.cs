using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Sosialisasi_Pemilukada.Process
{
    class json_faq
    {
        public string pertanyaan { get; set; }
        public string pasal { get; set; }
        public string isi_pasal { get; set; }
        public string jawab { get; set; }

        public int error { get; set; }

        public async void generate_faq(int x)
        {
            var strAPI = "http://localqhost/json/faq.php";
            var client = new HttpClient();

            Task<string> asyncData = client.GetStringAsync(strAPI);

            try
            {
                var jsonData = await asyncData;
                var parsed = JObject.Parse(jsonData);

                pertanyaan = (string)parsed["data"]["results"]["faqs"][x]["question_text"];
                pasal = (string)parsed["data"]["results"]["faqs"][x]["relevant_laws_regulations"];
                isi_pasal = (string)parsed["data"]["results"]["faqs"][x]["relevant_text"];
                jawab = (string)parsed["data"]["results"]["faqs"][x]["question_answer"];
            }
            catch (Exception ex)
            {
                error = 1;
                Console.WriteLine(ex);
            }
        }
    }
}
