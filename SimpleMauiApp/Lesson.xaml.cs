namespace SimpleMauiApp
{
    public partial class Lesson : ContentPage
    {
        public Lesson(bool showFirstSection)
        {
            InitializeComponent();
            FirstSection.IsVisible = true;
            Console.WriteLine($"showFirstSection received: {showFirstSection}");
            FirstSection.IsVisible = showFirstSection;
            FirstSection.ForceLayout();
            Console.WriteLine($"FirstSection visibility set to: {FirstSection.IsVisible}");
        }
    }
}