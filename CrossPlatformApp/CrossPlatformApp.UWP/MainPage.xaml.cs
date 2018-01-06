namespace CrossPlatformApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new CrossPlatformApp.App());
        }
    }
}