namespace Facebook.Models
{
    public class Businesses
    { //me?fields=businesses{id,name,permitted_roles,owned_pages,instagram_accounts,is_hidden,link}
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Permitted_Roles { get; set; }
        public OwnedPages Owned_Pages { get; set; }
        public InstagramAccounts Instagram_Accounts { get; set; }
        public bool Is_Hidden { get; set; }
        public string Link { get; set; }
    }
    public class OwnedPages
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class InstagramAccounts
    {
        public string Id { get; set; }
    }
}
