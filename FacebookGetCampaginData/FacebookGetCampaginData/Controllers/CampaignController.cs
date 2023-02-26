using Facebook.Services.Account;
using Microsoft.AspNetCore.Mvc;

namespace Facebook.Controllers
{
    [ApiController]
    [Route("Campaigns")]
    public class CampaignController : Controller
    {
        private static ICampaignData _campaignClient;
        public CampaignController(ICampaignData campaignData)
        {
            _campaignClient = campaignData;
        }
        [HttpGet("GetAdAccounts")]
        public async Task<IActionResult> GetAdAccountAsync(string pUser_Id)
        {
            var result = await _campaignClient.GetAdAccountsAsync(pUser_Id);
            return Ok(result);

        }
        [HttpGet("GetCampaign")]
        public async Task<IActionResult> GetCampaignAsync(string pAct_Acc_Id)
        {
            var result = await _campaignClient.GetCampaignAsync(pAct_Acc_Id);
            return Ok(result);

        }
        [HttpGet("GetCampaignInsights")]
        public async Task<IActionResult> GetCampaignInsightsAsync(string pAct_Acc_Id)
        {
            var result = await _campaignClient.GetCampaignInsightsAsync(pAct_Acc_Id);
            return Ok(result);
        }
        [HttpGet("GetAdvertisement")]
        public async Task<IActionResult> GetAdAsync(string pAct_Acc_Id)
        {
            var result = await _campaignClient.GetAdAsync(pAct_Acc_Id);
            return Ok(result);
        }
        [HttpGet("GetAdSets")]
        public async Task<IActionResult> GetAdSetAsync(string pAd_Set_Id)
        {
            var result = await _campaignClient.GetAdSetAsync(pAd_Set_Id);
            return Ok(result);
        }
    }
}
