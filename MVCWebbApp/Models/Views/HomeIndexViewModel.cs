using MVCWebbApp.Models.Sections;

namespace MVCWebbApp.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "Ultimate Task Management Assistant";
    public ShowcaseViewModel Showcase { get; set; } = new ShowcaseViewModel
    {
        Id = "overview",
        ShowcaseImage = new() { ImageUrl = "/images/showcase-image.svg", AltText = "Task Management Assistant" },
        Title = "Task Management Assistant You Gonna Love",
        Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
        Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
        BrandsText = "Largest companies use our tool to work efficiently",
        Brands =
                [
                    new() { ImageUrl = "/images/brands/brand_1.svg", AltText = "Brand Name 1" },
                    new() { ImageUrl = "/images/brands/brand_2.svg", AltText = "Brand Name 2" },
                    new() { ImageUrl = "/images/brands/brand_3.svg", AltText = "Brand Name 3" },
                    new() { ImageUrl = "/images/brands/brand_4.svg", AltText = "Brand Name 4" },
                ],

    };
    //public FeaturesViewModel Features { get; set; } = new FeaturesViewModel
    //{
    //    Id = "features",
    //    Title = "What Do You Get with Our Tool?",
    //    Description = "Make sure all of your tasks are organized so you can set the priorities and focus on important.",
    //    BoxTitleOne = "Comments on Tasks",
    //    BoxTextOne = "Id mollis consectetur congue egestas egestas suspendisse blandit justo.",
    //    BoxTitleTwo = "Task Analytics",
    //    BoxTextTwo = "Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate.",
    //    BoxTitleThree = "Multiple Assignees",
    //    BoxTextThree = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris.",
    //    BoxTitleFour = "Notifications",
    //    BoxTextFour = "Diam, suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra.",
    //    BoxTitleFive = "Sections & Subtasks",
    //    BoxTextFive = "Mi feugiat hac id in. Sit elit placerat lacus nibh lorem ridiculus lectus.",
    //    BoxTitleSix = "Data Security",
    //    BoxTextSix = "Aliquam malesuada neque eget elit nulla vestibulum nunc cras.",

    //};

    public LightDarkViewModel LightDark { get; set; } = new LightDarkViewModel
    {
        Id = "lightdark",
        TextOne = "Switch Between",
        TextTwo = "Light & Dark Mode",
        LightDarkImage = new() { ImageUrl = "images/light-dark.svg", AltText = "PC with Light & Dark Mode" },
        LightDarkIcon = new() { IconName = "fa-sharp fa-light fa-right-left", IconText = "" }
    };

    public ManageWorkViewModel ManageWork { get; set; } = new ManageWorkViewModel
    {
        Id = "managework",
        ManageWorkImage = new() { ImageUrl = "images/dashboard-image.svg", AltText = "Picture of a dashboard" },
        Title = "Manage Your Work",
        TextOne = "Powerful project management",
        TextTwo = "Transparent work management",
        TextThree = "Manage work & focus on the most important tasks",
        TextFour = "Track your progress with interactive charts",
        TextFive = "Easiest way to track time spent on tasks",
        Icon = new() { IconName = "fa-sharp fa-regular fa-circle-check" },
        Link = new() { ControllerName = "Home", ActionName = "Index", Text = "Learn More" }
    };

    public AppDevicesViewModel AppDevices { get; set; } = new AppDevicesViewModel
    {
        Id = "appdevices",
        Title = "Download Our App for Any Devices:",
        Text = "App Store",
        Icon = new() { IconName = "fa-sharp fa-solid fa-star" },
        TitleTwo = "Editor's Choice",
        TextTwo = "rating 4.7, 187k+ reviews",
        TextText = "Google Play",
        TitleThree = "App of the Day",
        TextThree = "rating 4.8, 30k+ reviews",
        Image = new() { ImageUrl = "/images/mobile-screens.svg", AltText = "Picture of two cellphones", ImageUrlTwo = "images/appstore.svg", AltTextTwo = "Picture of Appstore Logo", ImageUrlThree = "images/googleplay.svg", AltTextThree = "Picture of Googleplay" }
    };

    public WorkToolsViewModel WorkTools { get; set; } = new WorkToolsViewModel
    {
        Id = "worktools",
        Title = "Integrate Top Work Tools",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin volutpat mollis egestas. Nam luctus facilisis ultrices. Pellentesque volutpat ligula est. Mattis fermentum, at nec lacus.",
        TextOne = "Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.",
        TextTwo = "In eget a mauris quis. Tortor dui tempus quis integer est sit natoque placerat dolor.",
        TextThree = "Id mollis consectetur congue egestas egestas suspendisse blandit justo.",
        TextFour = "Rutrum interdum tortor, sed at nulla. A cursus bibendum elit purus cras praesent.",
        TextFive = "Congue pellentesque amet, viverra curabitur quam diam scelerisque fermentum urna.",
        TextSix = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris.",
        TextSeven = "Ut in turpis consequat odio diam lectus elementum. Est faucibus blandit platea.",
        TextEight = "Faucibus cursus maecenas lorem cursus nibh. Sociis sit risus id. Sit facilisis dolor arcu."
    };

    public SubscribeSectionViewModel SubscribeSection { get; set; } = new SubscribeSectionViewModel
    {
        Id = "subscribesection",
        Title = "Don't Want To Miss Anything?",
        Image = new() { ImageUrl = "images/vectorgroup.svg", AltText = "Squiggly line" },
        TitleTwo = "Sign up for Newsletters",
        TextOne = "Daily Newsletter",
        TextTwo = "Advertising Updates",
        TextThree = "Week in Review",
        TextFour = "Event Updates",
        TextFive = "Startups Weekly",
        TextSix = "Podcasts",
        Link = new() { ControllerName = "Home", ActionName = "Index" }
    };
}