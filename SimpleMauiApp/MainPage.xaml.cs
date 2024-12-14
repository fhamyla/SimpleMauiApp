using Microsoft.Maui.Controls;

namespace SimpleMauiApp;

public partial class MainPage : ContentPage
{
    private int clickCount = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        clickCount++;
        countLabel.Text = $"Button clicked {clickCount} times";
    }
}