
namespace SimpleMauiApp;

public partial class WelcomePage : ContentPage
{
    public WelcomePage(string nickname)
    {
        InitializeComponent();
        WelcomeLabel.Text = $"Hi {nickname}, Welcome Aboard";
    }

    private async void OnAlrightClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MotivationPage());
    }
}