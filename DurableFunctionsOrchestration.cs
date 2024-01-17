using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class DurableFunctionsOrchestration
    {
        [FunctionName("DurableFunctionsOrchestration")]
        public static async Task<List<string>> RunOrchestrator(
            [OrchestrationTrigger] IDurableOrchestrationContext context)
        {
            var outputs = new List<string>();

            var jobStatus = await context.CallActivityAsync<string>(nameof(RandomStatus), 2);
            if (jobStatus == "0")
            {
                outputs.Add(await context.CallActivityAsync<string>(nameof(Approval), "Aprovado"));
            }
            else{
                outputs.Add(await context.CallActivityAsync<string>(nameof(NotApproval), "Rejeitado"));
            }

            return outputs;
        }

        [FunctionName(nameof(Approval))]
        public static string Approval([ActivityTrigger] string resultado, ILogger log)
        {
            log.LogInformation("Seu pedido foi", resultado);
            return $"Seu pedido foi {resultado}!";
        }

        [FunctionName(nameof(NotApproval))]
        public static string NotApproval([ActivityTrigger] string resultado, ILogger log)
        {
            log.LogInformation("Seu pedido foi", resultado);
            return $"Seu pedido foi {resultado}!";
        }

        [FunctionName(nameof(RandomStatus))]
        public static string RandomStatus([ActivityTrigger] int number, ILogger log)
        {
            int result = RandomNumberGenerator.GetInt32(number);
            log.LogInformation("RandomNumberGenerator: ", number);
            return result.ToString();
        }

        [FunctionName("DurableFunctionsOrchestration_HttpStart")]
        public static async Task<HttpResponseMessage> HttpStart(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestMessage req,
            [DurableClient] IDurableOrchestrationClient starter,
            ILogger log)
        {
            // Function input comes from the request content.
            string instanceId = await starter.StartNewAsync("DurableFunctionsOrchestration", null);

            log.LogInformation("Started orchestration with ID = '{instanceId}'.", instanceId);

            return starter.CreateCheckStatusResponse(req, instanceId);
        }
    }
}