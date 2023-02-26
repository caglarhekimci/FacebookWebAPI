namespace Facebook.Models
{
    public class CampaignInsights
    {
        //act_2113195175412502/insights
        // act_2113195175412502/insights?breakdowns=publisher_platform&fields=ad_id,clicks,unique_clicks,cpm,impressions,reach,spend&default_summary=true&date_preset=maximum
        //act_2113195175412502/insights?breakdowns=publisher_platform&fields=ad_id,clicks,unique_clicks,cpm,impressions,reach,spend&date_preset=maximum
        public string Clicks { get; set; }
        public string UniqueClicks { get; set; }
        public string CPM { get; set; }
        public string Impressions { get; set; }
        public string Reach { get; set; }
        public string Spend { get; set; }
        public string DateStart { get; set; }
        public string DateStop { get; set; }
        public string PublisherPlatform { get; set; }
        public Dictionary<string, string>[] Data { get; set; }
    }
}
