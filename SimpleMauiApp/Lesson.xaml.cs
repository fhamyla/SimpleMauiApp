namespace SimpleMauiApp
{
    public partial class Lesson : ContentPage
    {
        public Lesson()
        {
            InitializeComponent();
        }

        public Lesson(bool showFirstSection) : this()
        {
            FirstSection.IsVisible = showFirstSection;
            Console.WriteLine($"FirstSection visibility set to: {showFirstSection}");
        }
    }
}