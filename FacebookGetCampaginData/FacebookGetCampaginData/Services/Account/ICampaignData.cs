using Facebook.Models;

namespace Facebook.Services.Account
{
    public interface ICampaignData
    {
        Task<List<AdAccount>> GetAdAccountsAsync(string pUser_Id);
        Task<List<Campaign>> GetCampaignAsync(string pAct_Acc_Id);
        Task<List<CampaignInsights>> GetCampaignInsightsAsync(string pAct_Acc_Id);
        Task<List<Advertisement>> GetAdAsync(string pAct_Acc_Id);
        Task<Ad_Set> GetAdSetAsync(string pAd_Set_Id);
    }
}
