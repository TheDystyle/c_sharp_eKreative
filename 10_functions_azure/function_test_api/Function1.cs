using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace function_test_api
{
    public static class Function1
    {
        
        [FunctionName("Function1")]

        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string[] arr = new string[] {"1 - Many hands make light work.",
                "2 - Strike while the iron is hot.",
                "3 - Honesty is the best policy.",
                "4 - The grass is always greener on the other side of the fence.",
                "5 - Don’t judge a book by its cover." };

            Random rnd = new Random();
            int value = rnd.Next(1, 5);

            log.LogInformation("C# HTTP trigger function processed a request.");
            //log.LogInformation(req.Path);
            //log.LogInformation("1 Lenght: " + req.Path.ToString());

            DateTime currentDateTime = DateTime.Now;
            //log.LogInformation(currentDateTime.ToString());
            log.LogInformation("Today is " + currentDateTime.DayOfWeek.ToString());

            string name = req.Query["name"];
            
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            Console.OutputEncoding = Encoding.UTF8;

            string responseMessage = string.IsNullOrEmpty(name)
                ? $"Sorry, parameter is empty"
                : $"Hello, {name}\n\n" +
                $"Random phrase:\n {arr[value]}\n\n" +
                $"Today is {currentDateTime.DayOfWeek.ToString()}\n\n" +
                $"Path: {req.Path.ToString()}\n" +
                $"Text: {req.Body.ToString()}\n" +
                $"Title: {req.ContentLength.ToString()}\n" +
                //$"{req.ContentType.ToString()}\n";// +
                //$"{req.Cookies.ToString()}\n";// +
                //$"{req.HasFormContentType.ToString()}\n" +
                //$"{req.Headers.ToString()}\n" +
                $"Host: {req.Host.ToString()}\n" +
                $"HttpContext: {req.HttpContext.ToString()}\n" +
                $"IsHttps: {req.IsHttps.ToString()}\n" +
                $"Method: {req.Method.ToString()}\n" +
                $"Protocol: {req.Protocol.ToString()}\n";// +
                //$"{req.Protocol.ToString()}\n" +
                //$"{req.Query.ToString()}\n" +
                //$"{req.QueryString.ToString()}\n" +
                //$"{req.Scheme.ToString()}\n";

            return new OkObjectResult(responseMessage);
        }
    }
}


