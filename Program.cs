using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace simple_json_reader
{
    class Program
    {
        public static JObject json = JObject.Parse(getJSON());
        static void Main(string[] args)
        {
            Console.WriteLine("JSON Çıktısı;");

            // JSON Çıktısı
            Console.WriteLine(json);

            // JSON'daki Değer Çıktısı
            Console.WriteLine(json.GetValue("age"));
        }

        public static String getJSON()
        {
            WebClient webClient = new WebClient();
            return webClient.DownloadString("https://raw.githubusercontent.com/poyraaz/simple-json-reader/main/example.json");
        }
    }
}
