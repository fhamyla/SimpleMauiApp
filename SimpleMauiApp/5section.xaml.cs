namespace SimpleMauiApp;

public partial class _5section : ContentPage
{
	public _5section()
	{
		InitializeComponent();
	}

    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _6section());
    }
}