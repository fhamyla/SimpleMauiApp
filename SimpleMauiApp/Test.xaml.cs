using System;
using Microsoft.Maui.Controls;

namespace SimpleMauiApp
{
    public partial class Test : ContentPage
    {
        private readonly Dictionary<string, string> _correctAnswers = new()
        {
            { "q1", "B" },
            { "q2", "A" },
            { "q3", "C" },
            { "q4", "D" },
            { "q5", "B" },
            { "q6", "B" },
            { "q7", "B" },
            { "q8", "A" },
            { "q9", "D" },
            { "q10", "D" },
            { "q11", "A" },
            { "q12", "C" },
            { "q13", "B" },
            { "q14", "A" },
            { "q15", "D" },
            { "q16", "A" },
            { "q17", "D" },
            { "q18", "A" },
            { "q19", "B" },
            { "q20", "A" }
        };

        private int _score = 0;
        private readonly TimeSpan _timeLimit = TimeSpan.FromMinutes(15);
        private DateTime _startTime;

        public Test()
        {
            InitializeComponent();
            StartTimer();
        }

        private void StartTimer()
        {
            _startTime = DateTime.Now;

            Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                TimeSpan remainingTime = _timeLimit - (DateTime.Now - _startTime);

                if (remainingTime <= TimeSpan.Zero)
                {
                    EndTest();
                    return false; // Stop the timer
                }

                return true; // Continue the timer
            });
        }

        private void EndTest()
        {
            CalculateScore();
            DisplayScore();
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            EndTest();
        }

        private void CalculateScore()
        {
            _score = 0;

            foreach (var entry in _correctAnswers)
            {
                string groupName = entry.Key;
                string correctAnswer = entry.Value;

                RadioButton selectedOption = this.FindByName<RadioButton>($"{groupName}_selected");
                if (selectedOption?.Content?.ToString()?.StartsWith(correctAnswer) == true)
                {
                    _score++;
                }
            }
        }

        private async void DisplayScore()
        {
            string resultMessage = _score switch
            {
                <= 12 => "Failed",
                13 or 14 => "Average",
                15 or 16 => "Good",
                17 or 18 => "Very Good!",
                >= 19 or 20 => "Excellent!"
            };
            await DisplayAlert("Test Completed", $"Your score is: {_score}/20\nResult: {resultMessage}", "OK");

            await Navigation.PopAsync();
        }
    }
}