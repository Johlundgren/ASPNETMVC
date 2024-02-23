using MVCWebbApp.Models;

namespace MVCWebbApp.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        ProfileImage = "/images/mailchimp.svg",
        FirstName = "Johan",
        LastName = "Lundgren",
        Email = "jojje@domain.com"
    };
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
    
    
}
