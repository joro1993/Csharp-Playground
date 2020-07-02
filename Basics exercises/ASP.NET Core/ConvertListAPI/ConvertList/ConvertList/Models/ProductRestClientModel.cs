using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConvertList.Models
{
    public class ProductRestClientModel
    {
        private string BASE_URL = "https://localhost:44366/api/product/";
        public Task<HttpResponseMessage> FindAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync("findall");
            } 
            catch
            {
                return null;
            }
        }
    }
}
