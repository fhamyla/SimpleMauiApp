namespace SimpleMauiApp;

public partial class _7section : ContentPage
{
	public _7section()
	{
		InitializeComponent();
	}

    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _8section());
    }
}