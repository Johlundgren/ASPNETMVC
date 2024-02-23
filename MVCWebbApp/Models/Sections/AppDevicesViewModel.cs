using MVCWebbApp.Models.Components;

namespace MVCWebbApp.Models.Sections;

public class AppDevicesViewModel
{
    public string? Id { get; set; }

    public string? Title { get; set; }
    public string? Text { get; set; }
    public IconViewModel Icon { get; set; } = null!;
    public string? TitleTwo {  get; set; }
    public string? TextTwo { get; set; }
    public string? TextText { get; set; }
    public string? TitleThree { get; set; }
    public string? TextThree { get; set; }

    public ImageViewModel Image { get; set; } = null!;

}
