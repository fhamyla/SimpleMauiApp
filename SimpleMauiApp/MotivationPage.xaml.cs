namespace SimpleMauiApp;

public partial class MotivationPage : ContentPage
{
	public MotivationPage()
	{
		InitializeComponent();
	}
    private async void OnContinueClicked(object sender, EventArgs e)
    {
        string motivation = string.Empty;

        if (StudentOption.IsChecked)
        {
            motivation = "I am a student and new to this Operating System";
        }
        else if (UpskillOption.IsChecked)
        {
            motivation = "I want to be able to learn how does an Operating System works";
        }
        else if (WillingToLearnOption.IsChecked)
        {
            motivation = "I'm looking for new knowledge";
        }

        if (!string.IsNullOrEmpty(motivation))
        {
            await DisplayAlert("Selected Motivation", $"You selected: {motivation}", "OK");
            await Navigation.PushAsync(new CodingKnowledgePage());
        }
        else
        {
            await DisplayAlert("Error", "Please select an option to continue.", "OK");
        }
    }
}