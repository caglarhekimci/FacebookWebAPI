using Facebook.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http.Headers;

namespace Facebook.Services.Account
{
    public class CampaignData : ICampaignData
    {
        private static HttpClient _httpClient;

        private static IConfiguration _config;

        public CampaignData(IConfiguration config)
        {
            _config = config;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://graph.facebook.com/v15.0/")
            };
            _httpClient.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<AdAccount>> GetAdAccountsAsync(string pUser_Id)
        {
            string accessUserToken = _config["GraphAPI:AccessUserToken"];
            string userEndpoint = "adaccounts?fields=account_id,id,name";
            var response = await _httpClient.GetAsync($"{pUser_Id}/{userEndpoint}&access_token={accessUserToken}");
            var responseBody = await response.Content.ReadAsStringAsync();
            var respondObject = JsonConvert.DeserializeObject<AdAccount>(responseBody);
            Dictionary<string, string>[] data = respondObject.Data;

            List<AdAccount> allAdAccounts = new List<AdAccount>();

            foreach (var adAccDictionary in data)
            {
                AdAccount adAcc = new AdAccount
                {
                    Account_Id = adAccDictionary["account_id"],
                    Id = adAccDictionary["id"],
                    Name = adAccDictionary["name"],
                };

                allAdAccounts.Add(adAcc);
            }


            return allAdAccounts;
        }
        public async Task<List<Campaign>> GetCampaignAsync(string pAct_Acc_Id)
        {
            string accessUserToken = _config["GraphAPI:AccessUserToken"];
            string userEndpoint = "campaigns?fields=name,id,status,objective,insights{impressions}";
            var response = await _httpClient.GetAsync($"{pAct_Acc_Id}/{userEndpoint}&access_token={accessUserToken}");
            var responseBody = await response.Content.ReadAsStringAsync();
            var respondObject = JsonConvert.DeserializeObject<Campaign>(responseBody);
            Dictionary<string,string>[] data = respondObject.Data;

            List<Campaign> allCampaigns = new List<Campaign>();

            foreach (var campaignDictionary in data)
            {
                Campaign campaign = new Campaign
                {
                    Name = campaignDictionary["name"],
                    Id = campaignDictionary["id"],
                    Status = campaignDictionary["status"],
                    Objective = campaignDictionary["objective"],
                };

                allCampaigns.Add(campaign);
            }

            
            return allCampaigns;
        }
        public async Task<List<CampaignInsights>> GetCampaignInsightsAsync(string pAct_Acc_Id)
        {
            string accessUserToken = _config["GraphAPI:AccessUserToken"];
            string userEndpoint = "insights?breakdowns=publisher_platform&fields=ad_id,clicks,unique_clicks,cpm,impressions,reach,spend&date_preset=maximum";
            var response = await _httpClient.GetAsync($"{pAct_Acc_Id}/{userEndpoint}&access_token={accessUserToken}");
            var responseBody = await response.Content.ReadAsStringAsync();
            var respondObject = JsonConvert.DeserializeObject<CampaignInsights>(responseBody);
            Dictionary<string, string>[] data = respondObject.Data;

            List<CampaignInsights> campaignInsights = new List<CampaignInsights>();

            foreach (var campaignDictionary in data)
            {
                CampaignInsights insights = new CampaignInsights
                {
                    Clicks = campaignDictionary["clicks"],
                    UniqueClicks = campaignDictionary["unique_clicks"],
                    CPM = campaignDictionary["cpm"],
                    Impressions = campaignDictionary["impressions"],
                    Reach = campaignDictionary["reach"],
                    Spend = campaignDictionary["spend"],
                    DateStart = campaignDictionary["date_start"],
                    DateStop = campaignDictionary["date_stop"],
                    PublisherPlatform = campaignDictionary["publisher_platform"],
                };

                campaignInsights.Add(insights);
            }

            return campaignInsights;
        }

        public async Task<List<Advertisement>> GetAdAsync(string pAct_Acc_Id) // CHANGE HERE we need to list them with using AdSetId
        {
            string accessUserToken = _config["GraphAPI:AccessUserToken"];
            string userEndpoint = "ads?fields=id,name,status,created_time,effective_status,insights.date_preset(maximum).fields(impressions,spend)";
            var response = await _httpClient.GetAsync($"{pAct_Acc_Id}/{userEndpoint}&access_token={accessUserToken}");
            var responseBody = await response.Content.ReadAsStringAsync();
            var respondObject = JsonConvert.DeserializeObject<Advertisement>(responseBody); // NOT WORKING
            Dictionary<string, string>[] data = respondObject.Data;

            List<Advertisement> ads = new List<Advertisement>();
           // List<AdsInsights> insights = new List<AdsInsights>();

            foreach (var adDictionary in data)
            {
                Advertisement ad = new Advertisement
                {
                    Id = adDictionary["id"],
                    Name = adDictionary["name"],
                    Status = adDictionary["status"],
                    Created_Time = adDictionary["created_time"],
                    Effective_Status = adDictionary["effective_status"],
                };
                ads.Add(ad);

                ////AdsInsights insight = new AdsInsights-
                //{
                //    Impressions = adDictionary["impressions"],
                //    Spend = adDictionary["spend"],
                //    Date_Start = adDictionary["date_start"],
                //    Date_Stop = adDictionary["date_stop"],
                //};
                //insights.Add(insight);
            }

            return ads;
        }
        public async Task<Ad_Set> GetAdSetAsync(string pAd_Set_Id) 
        {
            string accessUserToken = _config["GraphAPI:AccessUserToken"];
            string userEndpoint = "?fields=id,name,status,bid_amount"; // CHANGE HERE we need to list them with using campaignId
            var response = await _httpClient.GetAsync($"{pAd_Set_Id}{userEndpoint}&access_token={accessUserToken}");
            var responseBody = await response.Content.ReadAsStringAsync();
            Ad_Set adSet = JsonConvert.DeserializeObject<Ad_Set>(responseBody);

            return adSet;
        }
    }
}
