namespace SimpleMauiApp;

public partial class _4section : ContentPage
{
	public _4section()
	{
		InitializeComponent();
	}

    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _5section());
    }
}