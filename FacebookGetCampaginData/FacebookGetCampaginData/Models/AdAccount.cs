namespace Facebook.Models
{
    public class AdAccount
    {
        //5336917476398020/adaccounts - {user-id}/adaccounts
        public string Account_Id { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public Dictionary<string, string>[] Data { get; set; }

    }
}
