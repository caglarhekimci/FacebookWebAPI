namespace Facebook.Models
{
    public class Campaign
    {
        // act_2113195175412502/campaigns?fields=name,id,status,objective,insights{impressions}
        public string Name { get; set; }
        public string Id { get; set; }
        public string Status { get; set; }
        public string Objective { get; set; }
        public Dictionary<string, string>[] Data { get; set; }
    }
}
