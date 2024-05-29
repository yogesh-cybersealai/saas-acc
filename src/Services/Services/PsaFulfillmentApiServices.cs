using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Marketplace.SaaS.Accelerator.Services.Contracts;
using Marketplace.SaaS.Accelerator.Services.Models;
using Microsoft.Extensions.Logging;
 
namespace Marketplace.SaaS.Accelerator.Services.Services;
 
public class PsaFulfillmentApiServices : IPsaFulfillmentApiServices
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<PsaFulfillmentApiServices> _logger;
 
    public PsaFulfillmentApiServices(HttpClient httpClient, ILogger<PsaFulfillmentApiServices> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<PsaDeploymentResult> ActivateDeploymentAsync(Guid subscriptionId, string subscriptionPlanID, string userId)
        {
            _logger.LogInformation("Activating deployment for subscription ID: {SubscriptionId}", subscriptionId);
            var subscription = new
            {
                SubscriptionId = subscriptionId,
                SubscriptionPlanID = subscriptionPlanID,
                UserId = userId
            };
            
            var json = JsonSerializer.Serialize(subscription);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                _logger.LogInformation("Sending subscription data to PSA service for subscription ID: {SubscriptionId}", subscriptionId);
                var response = await _httpClient.PostAsync("https://demo.cybersealai.com/backend/marketplace/webhook", content);

                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<PsaDeploymentResult>(responseContent);

                _logger.LogInformation("Received response from PSA service for subscription ID: {SubscriptionId}", subscriptionId);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending subscription data to PSA service for subscription ID: {SubscriptionId}", subscriptionId);
                throw;
            }
        }
}