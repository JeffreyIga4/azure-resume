using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    public static class GetResumeCounter
    {
        [FunctionName("GetResumeCounter")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            // Code here binds the counter object to the CosmosDB container
            // The Id and PartitionKey are set to "1" because there is only one counter in the container
            [CosmosDB(databaseName: "AzureResume", containerName: "Counter", Connection = "AzureResumeConnectionString", Id = "1", PartitionKey = "1")] Counter counter,
            [CosmosDB(databaseName: "AzureResume", containerName: "Counter", Connection = "AzureResumeConnectionString", Id = "1", PartitionKey = "1")] out Counter updatedCounter,
            ILogger log)
        {
            // Here is where the counter gete updated
            log.LogInformation("C# HTTP trigger function processed a request.");

            // Increment the counter
            updatedCounter = counter;
            updatedCounter.Count += 1;

            // Serialize the counter object to JSON
            var jsonToReturn = JsonConvert.SerializeObject(counter);


            // Return the counter object as JSON
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                // Set the Content of the response to the JSON string
                Content = new StringContent(jsonToReturn, System.Text.Encoding.UTF8, "application/json")
            };
        }
    }
}
