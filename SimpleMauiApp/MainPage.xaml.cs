using Microsoft.Maui.Controls;

namespace SimpleMauiApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnConfirmClicked(object sender, EventArgs e)
    {
        string nickname = NicknameEntry.Text;
        if (!string.IsNullOrEmpty(nickname))
        {
            await Navigation.PushAsync(new WelcomePage(nickname));
        }
        else
        {
            await DisplayAlert("Error", "Please choose a nickname.", "OK");
        }
    }
}