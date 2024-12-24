using Microsoft.Maui.Controls;

namespace SimpleMauiApp
{
    public partial class Lesson : ContentPage
    {
        public Lesson()
        {
            InitializeComponent();
        }

        private async void OnTestTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Test());
        }
        private async void GetTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GettingStarted());
        }
        private async void SecTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _2section());
        }
        private async void ThTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _3section());
        }
        private async void FTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _4section());
        }
        private async void FfTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _5section());
        }
        private async void STapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _6section());
        }
        private async void SevTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _7section());
        }
        private async void ETapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _8section());
        }
    }
}