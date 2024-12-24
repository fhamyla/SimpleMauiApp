namespace SimpleMauiApp;

public partial class _6section : ContentPage
{
	public _6section()
	{
		InitializeComponent();
	}

    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _7section());
    }
}