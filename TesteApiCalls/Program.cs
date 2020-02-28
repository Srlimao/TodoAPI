using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace TesteApiCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44387/api/");

                ConsoleListAll(client);

                string jsonInString = @"{""Title"": ""title"",""DueDate"": ""2020-01-01""}";

                var postTask = client.PostAsync("Todo", new StringContent(jsonInString, Encoding.UTF8, "application/json"));
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine("Post add item realizado");
                }
                else
                {
                    Console.WriteLine("Post add item erro "+result.StatusCode);
                }

                ConsoleListAll(client);


            }
            Console.ReadLine();
        }

        public static void ConsoleListAll(HttpClient client)
        {
            //HTTP GET
            var responseTask = client.GetAsync("Todo");
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {

                var readTask = result.Content.ReadAsStringAsync();
                readTask.Wait();

                var itensJson = readTask.Result;

                Console.WriteLine(itensJson);
            }
        }
    }
}
