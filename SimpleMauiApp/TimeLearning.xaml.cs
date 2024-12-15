using System;
using Microsoft.Maui.Controls;

namespace SimpleMauiApp
{
    public partial class TimeLearning : ContentPage
    {
        public TimeLearning()
        {
            InitializeComponent();
        }

        private async void OnContinueClicked(object sender, EventArgs e)
        {
            string timeLevel = string.Empty;
            TimeSpan notificationTime = TimeSpan.Zero;

            if (LaidBackOption.IsChecked)
            {
                timeLevel = "5-10 minutes a day";
                notificationTime = TimeSpan.FromMinutes(10);
            }
            else if (ConsistentOption.IsChecked)
            {
                timeLevel = "10-15 minutes everyday";
                notificationTime = TimeSpan.FromMinutes(15);
            }
            else if (SincereOption.IsChecked)
            {
                timeLevel = "20 minutes everyday";
                notificationTime = TimeSpan.FromMinutes(20);
            }

            if (!string.IsNullOrEmpty(timeLevel))
            {
                await DisplayAlert("Time Learning", $"You selected: {timeLevel}", "OK");

                // Schedule notification using the Dispatcher
                ScheduleNotification(notificationTime);

                // Navigate to the Lesson page with FirstSection visible or hidden based on logic
                bool showFirstSection = false; // Set this to true or false based on your requirements
                await Navigation.PushAsync(new Lesson(showFirstSection));
            }
            else
            {
                await DisplayAlert("Error", "Please select an option to continue.", "OK");
            }
        }

        private void ScheduleNotification(TimeSpan delay)
        {
            // Use the Dispatcher to schedule the notification
            Dispatcher.DispatchDelayed(delay, () =>
            {
                DisplayAlert("Reminder", "It's time for your learning session!", "OK");
            });
        }
    }
}