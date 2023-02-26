using System;

namespace Facebook.Models
{
    public class Advertisement
    {
        //act_2113195175412502/ads?fields=id,name,status,created_time,effective_status,insights.date_preset(maximum).fields(impressions,spend)
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Created_Time { get; set; }
        public string Effective_Status { get; set; }
        //public AdsInsights Insights { get; set; }
        public Dictionary<string, string>[] Data { get; set; }
    }
    //public class AdsInsights
    //{
    //    public string Impressions { get; set; }
    //    public string Spend { get; set; }
    //    public string Date_Start { get; set; }
    //    public string Date_Stop { get; set; }
    //    public Dictionary<string, string>[] Data { get; set; }

    //}
}
