using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace IntegrationWorks.functions
{
    public class Hello_world_james_iw
    {
        private readonly ILogger<Hello_world_james_iw> _logger;

        public Hello_world_james_iw(ILogger<Hello_world_james_iw> logger)
        {
            _logger = logger;
        }

        [Function("Hello_world_james_iw")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
