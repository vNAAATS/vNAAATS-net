using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace vNAAATS.API
{
    public static class GetApiInfo
    {
        [FunctionName("ApiInfoGet")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string res = "This is the vNAAATS API version 1.0. The vNAAATS API serves data to currently active vNAAATS stations as well as providing a public facing API for vNAAATS data to be parsed.\nPlease contact a.ogden@vatcan.ca for more information.";

            return (ActionResult)new OkObjectResult(res);
        }
    }
}

