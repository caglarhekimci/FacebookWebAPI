using System.Collections.Generic;
using System.Reflection;

namespace Facebook.Models
{
    public class Ad_Set
    {
        //act_2113195175412502/ads?fields=id,name,status,created_time,effective_status WE FOUND IN HERE WITH "ID"
        //23849686365740101?fields=id,name,status,bid_amount,targeting
        // ad-set-id
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string BidAmount { get; set; }
        //public Dictionary<string, string>[] Target { get; set; }
    }
}
