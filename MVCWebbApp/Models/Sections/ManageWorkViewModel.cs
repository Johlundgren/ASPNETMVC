using MVCWebbApp.Models.Components;

namespace MVCWebbApp.Models.Sections;

public class ManageWorkViewModel
{
    public string? Id { get; set; }
    public ImageViewModel ManageWorkImage { get; set; } = null!;
    public string? Title { get; set; }
    public string? TextOne { get; set; }
    public string? TextTwo { get; set;}
    public string? TextThree { get; set;}
    public string? TextFour { get; set;}
    public string? TextFive { get; set;}
    public IconViewModel Icon { get; set; } = null!;
    public LinkViewModel Link { get; set; } = new LinkViewModel();
}
