using MVCWebbApp.Models.Components;

namespace MVCWebbApp.Models.Sections;

public class SubscribeSectionViewModel
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public ImageViewModel Image { get; set; } = null!;
    public string? TitleTwo {  get; set; }
    public string? TextOne { get; set; }
    public string? TextTwo { get; set; }
    public string? TextThree { get; set; }
    public string? TextFour { get; set; }
    public string? TextFive { get; set; }
    public string? TextSix { get; set; }
    public LinkViewModel Link { get; set; } = null!;
}
