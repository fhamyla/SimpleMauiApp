namespace SimpleMauiApp;

public partial class CodingKnowledgePage : ContentPage
{
	public CodingKnowledgePage()
	{
		InitializeComponent();
	}
    private async void OnContinueClicked(object sender, EventArgs e)
    {
        string knowledgeLevel = string.Empty;

        if (NoneOption.IsChecked)
        {
            knowledgeLevel = "I used them and quite confused how they work";
        }
        else if (BasicOption.IsChecked)
        {
            knowledgeLevel = "I already know but I want to know other features how it works";
        }
        else if (ExperiencedOption.IsChecked)
        {
            knowledgeLevel = "Not much but I'm interested how to use an OS such as like Windows and IOS";
        }

        if (!string.IsNullOrEmpty(knowledgeLevel))
        {
            await DisplayAlert("Coding Knowledge", $"You selected: {knowledgeLevel}", "OK");
            await Navigation.PushAsync(new TimeLearning());
        }
        else
        {
            await DisplayAlert("Error", "Please select an option to continue.", "OK");
        }
    }
}