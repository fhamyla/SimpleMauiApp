namespace SimpleMauiApp;

public partial class _3section : ContentPage
{
	public _3section()
	{
		InitializeComponent();
	}

    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _4section());
    }
}