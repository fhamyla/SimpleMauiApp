namespace SimpleMauiApp;

public partial class GettingStarted : ContentPage
{
	public GettingStarted()
	{
		InitializeComponent();
	}

	private async void NextClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new _2section());
	}
}