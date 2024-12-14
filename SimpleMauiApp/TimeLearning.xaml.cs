namespace SimpleMauiApp;

public partial class TimeLearning : ContentPage
{
	public TimeLearning()
	{
		InitializeComponent();
	}
    private async void OnContinueClicked(object sender, EventArgs e)
    {
        string timeLevel = string.Empty;

        if (LaidBackOption.IsChecked)
        {
            timeLevel = "5-10 minutes a day";
        }
        else if (ConsistentOption.IsChecked)
        {
            timeLevel = "10-15 minutes everyday";
        }
        else if (SincereOption.IsChecked)
        {
            timeLevel = "20 minutes everyday";
        }

        if (!string.IsNullOrEmpty(timeLevel))
        {
            await DisplayAlert("Time Learning", $"You selected: {timeLevel}", "OK");
        }
        else
        {
            await DisplayAlert("Error", "Please select an option to continue.", "OK");
        }
    }
}