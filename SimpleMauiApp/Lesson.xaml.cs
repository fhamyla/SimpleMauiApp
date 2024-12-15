namespace SimpleMauiApp
{
    public partial class Lesson : ContentPage
    {
        public Lesson(bool showFirstSection)
        {
            InitializeComponent();

            Console.WriteLine($"Constructor received showFirstSection = {showFirstSection}");
            FirstSection.IsVisible = showFirstSection;
            FirstSection.ForceLayout();
            Console.WriteLine($"FirstSection visibility after assignment: {FirstSection.IsVisible}");
        }
    }
}