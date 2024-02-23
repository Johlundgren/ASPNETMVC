using MVCWebbApp.Models.Components;

namespace MVCWebbApp.Models.Sections;

public class LightDarkViewModel
{
    public string? Id { get; set; }
    public string? TextOne { get; set; }
    public string? TextTwo { get; set; }
    public ImageViewModel LightDarkImage { get; set; } = null!;
    public IconViewModel LightDarkIcon { get; set; } = null!;
}
