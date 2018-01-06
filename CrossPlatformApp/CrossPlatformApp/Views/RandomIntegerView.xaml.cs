using CrossPlatformApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatformApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RandomIntegerView : ContentPage
    {
        public RandomIntegerView(RandomIntegerViewModel viewModel)
        {
            BindingContext = viewModel;

            InitializeComponent();
        }
    }
}