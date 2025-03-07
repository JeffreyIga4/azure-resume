// A proxy function that proctects the api key 

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

public static class ProxyGetResumeCounter
{
    private static readonly HttpClient client = new HttpClient();

    [FunctionName("ProxyGetResumeCounter")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
        ILogger log)
    {
        string apiKey = Environment.GetEnvironmentVariable("FUNCTION_API_KEY");

        if (string.IsNullOrEmpty(apiKey))
        {
            log.LogError("API Key not found in environment variables.");
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }

        string functionUrl = $"https://getresumecounter-eu.azurewebsites.net/api/GetResumeCounter?code={apiKey}";

        try
        {
            var response = await client.GetStringAsync(functionUrl);
            return new OkObjectResult(response);
        }
        catch (HttpRequestException ex)
        {
            log.LogError($"Error calling function: {ex.Message}");
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
    }
}
