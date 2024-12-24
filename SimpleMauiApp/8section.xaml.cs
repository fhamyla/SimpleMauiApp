namespace SimpleMauiApp;

public partial class _8section : ContentPage
{
	public _8section()
	{
		InitializeComponent();
	}

    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Test());
    }
}