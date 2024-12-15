namespace SimpleMauiApp
{
    public partial class CodingKnowledgePage : ContentPage
    {
        public CodingKnowledgePage()
        {
            InitializeComponent();
        }

        private async void ContinueClicked(object sender, EventArgs e)
        {
            bool showFirstSection = false; // Default is false (hidden)

            if (BasicOption.IsChecked)
            {
                showFirstSection = true; // Make it visible for BasicOption
                Console.WriteLine("BasicOption selected. FirstSection should be visible.");
            }
            else if (ExperiencedOption.IsChecked || MasterOption.IsChecked)
            {
                showFirstSection = false; // Hide it for other options
                Console.WriteLine("ExperiencedOption or MasterOption selected. FirstSection should be hidden.");
            }

            // Navigate to Lesson with the determined visibility
            Console.WriteLine($"Navigating to Lesson with showFirstSection = {showFirstSection}");
            await Navigation.PushAsync(new Lesson(showFirstSection));
        }

        private async void OnContinueClicked(object sender, EventArgs e)
        {
            string knowledgeLevel = string.Empty;

            if (BasicOption.IsChecked)
            {
                knowledgeLevel = "I used them and quite confused how they work";
            }
            else if (ExperiencedOption.IsChecked)
            {
                knowledgeLevel = "I already know but I want to know other features how it works";
            }
            else if (MasterOption.IsChecked)
            {
                knowledgeLevel = "Not much but I'm interested how to use an OS such as like Windows and IOS";
            }

            if (!string.IsNullOrEmpty(knowledgeLevel))
            {
                await DisplayAlert("Coding Knowledge", $"You selected: {knowledgeLevel}", "OK");

                // Pass the selected option to TimeLearning page
                await Navigation.PushAsync(new TimeLearning());
            }
            else
            {
                await DisplayAlert("Error", "Please select an option to continue.", "OK");
            }
        }
    }
}