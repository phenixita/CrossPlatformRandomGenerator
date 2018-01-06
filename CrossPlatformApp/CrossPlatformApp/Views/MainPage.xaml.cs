using CrossPlatformApp.Core;
using CrossPlatformApp.ViewModels;
using System;
using Xamarin.Forms;

namespace CrossPlatformApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RandomIntegerView(new RandomIntegerViewModel(new RandomGenerator())));
        }
    }
}