namespace Facebook.Models
{
    public class BusinessUser
    { // me?fields=business_users{email,name,id,business,role,two_fac_status,assigned_pages, assigned_business_asset_groups,assigned_ad_accounts}
        public string Name { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public string Role { get; set; }
        public string Two_Fac_Status { get; set; }
        public AssignedPages Assigned_Pages { get; set; }
        public AssignedBusinessAssetGroups Assigned_Business_Asset_Groups { get; set; }
        public AssignedAdAccounts Assigned_Ad_Accounts { get; set; }
    }

    public class AssignedPages
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Tasks { get; set; }
    }

    public class AssignedBusinessAssetGroups
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Page_Tasks { get; set; }
    }

    public class AssignedAdAccounts
    {
        public string Id { get; set; }
        public string Account_Id { get; set; }
        public List<string> Tasks { get; set; }
    }
}
