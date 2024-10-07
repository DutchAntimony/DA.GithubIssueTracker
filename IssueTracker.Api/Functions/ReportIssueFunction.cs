using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace IssueTracker.Api.Functions
{
    public class ReportIssueFunction(ILogger<ReportIssueFunction> logger)
    {
        [FunctionName("ReportIssueFunction")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "issues")] HttpRequest req)
        {
            logger.LogInformation("[POST] Report an issue.");

            return new OkResult();
        }
    }
}
