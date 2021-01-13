using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionSach.ConnectionAPI
{
    public class Connection
    {
        private string url = "http://localhost:4000/api/v1";

        public async Task<HttpResponseMessage> PostHTTP(dynamic objetc, string urlF)
        {
            string json = JsonConvert.SerializeObject(objetc);

            var client = new HttpClient();

            return await client.PostAsync(url + urlF, new StringContent(json, Encoding.UTF8, "application/json"));

        }

        public async Task<string> GetHttp(string urlF)
        {
            WebRequest oRequest = WebRequest.Create(url + urlF);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        public async Task<HttpResponseMessage> UpdateHTTP(dynamic objetc, string urlF)
        {
            string json = JsonConvert.SerializeObject(objetc);

            var client = new HttpClient();
            HttpResponseMessage response = await client.PutAsync(url + urlF, new StringContent(json, Encoding.UTF8, "application/json"));

            return response;
        }

    }
}
