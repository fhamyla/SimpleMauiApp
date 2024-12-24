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
    }
}