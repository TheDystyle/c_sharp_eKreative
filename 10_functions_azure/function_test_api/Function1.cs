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
            log.LogInformation("C# HTTP trigger function processed a request.");

            // random phrase
            string[] arr = new string[] {"1 - Many hands make light work.",
                "2 - Strike while the iron is hot.",
                "3 - Honesty is the best policy.",
                "4 - The grass is always greener on the other side of the fence.",
                "5 - Don’t judge a book by its cover." };

            Random rnd = new Random();
            int value = rnd.Next(1, 5);

            // day of week
            DateTime currentDateTime = DateTime.Now;
            string dayOfWeek = currentDateTime.DayOfWeek.ToString();
            log.LogInformation("Today is " + dayOfWeek);


            // status
            string[] statusArr =
            {
                req.Path.ToString(),
                req.Body.ToString(),
                req.ContentLength.ToString(),
                req.Host.ToString(),
                req.HttpContext.ToString(),
                req.IsHttps.ToString(),
                req.Method.ToString(),
                req.Protocol.ToString()
            };
            string name = req.Query["name"];
            
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            var myRequest = new OutputJSON(arr[value], dayOfWeek, statusArr);
            string json = JsonConvert.SerializeObject(myRequest);
            log.LogInformation(json);

            string responseMessage = string.IsNullOrEmpty(name)
                ? $"Sorry, parameter is empty"
                : $"Hello {name}\n" +
                $"You data:\n" +
                $" {json}";
                /*$"Hello, {name}\n\n" +
                $"Random phrase:\n {arr[value]}\n\n" +
                $"Today is {currentDateTime.DayOfWeek.ToString()}\n\n" +
                $"Path: {req.Path.ToString()}\n" +
                $"Text: {req.Body.ToString()}\n" +
                $"Title: {req.ContentLength.ToString()}\n" +
                $"Host: {req.Host.ToString()}\n" +
                $"HttpContext: {req.HttpContext.ToString()}\n" +
                $"IsHttps: {req.IsHttps.ToString()}\n" +
                $"Method: {req.Method.ToString()}\n" +
                $"Protocol: {req.Protocol.ToString()}\n";*/

            return new OkObjectResult(responseMessage);
        }
    }

    public class OutputJSON
    {
        public string? Phrase { get; set; }
        public string? DayOfWeek { get; set; }
        public Array Status { get; set; }
        public OutputJSON(string phrase, string dayNow, Array status)
        {
            Phrase = phrase;
            DayOfWeek = dayNow;
            Status = status;
        }
    }
}


