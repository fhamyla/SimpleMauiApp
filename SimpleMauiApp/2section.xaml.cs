namespace SimpleMauiApp;

public partial class _2section : ContentPage
{
	public _2section()
	{
		InitializeComponent();
	}

    private async void NextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _3section());
    }
}