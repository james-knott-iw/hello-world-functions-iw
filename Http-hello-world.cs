using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace IW.Function
{
    public class Http_hello_world
    {
        private readonly ILogger<Http_hello_world> _logger;

        public Http_hello_world(ILogger<Http_hello_world> logger)
        {
            _logger = logger;
        }

        [Function("Http_hello_world")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Hello World!");
        }
    }
}
