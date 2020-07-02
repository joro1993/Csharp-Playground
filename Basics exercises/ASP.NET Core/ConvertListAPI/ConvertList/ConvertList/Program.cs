using ConvertList.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace ConvertList
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRestClientModel = new ProductRestClientModel();
            var httpResponseMessage = productRestClientModel.FindAll().Result;

            HttpStatusCode httpStatusCode = httpResponseMessage.StatusCode;
            Console.WriteLine("Status Code: " + httpStatusCode);

            bool IsSucessStatusCode = httpResponseMessage.IsSuccessStatusCode;
            Console.WriteLine("Sucess: " + IsSucessStatusCode);

            List<Product> products = httpResponseMessage.Content.ReadAsAsync<List<Product>>().Result;
            Console.WriteLine("product List");
            foreach(var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("==================================");
            }

            Console.ReadLine();
        }
    }
}
