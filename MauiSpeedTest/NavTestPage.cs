using System.Diagnostics;
using CSharpForMarkup;

namespace MauiSpeedTest;

public class NavTestPage : ContentPage
{
    private Grid grid;
    private Stopwatch stopwatch;
    private Label timerLabel;
    public NavTestPage()
	{
        stopwatch = new Stopwatch();
        stopwatch.Start();

        timerLabel = new Label
        {
            Style = MarkupStyles.TimerLabelStyle
        }
           .Row(0);

        var outterGrid = new Grid
        {
            RowDefinitions =
            {
                new RowDefinition { Height = 100 },
                new RowDefinition {Height = GridLength.Star }
            }
        };
        grid = new Grid
        {

            Style = MarkupStyles.FillLayoutStyle,
            RowSpacing = 1,
            ColumnSpacing = 1,
            RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },

                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },

                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },

                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },

                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
                },

            ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },

                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },

                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },

                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },

                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star }
                },

        }.Row(1);
        AssignGridItems();
        outterGrid.Children.Add(timerLabel);
        outterGrid.Children.Add(grid);
        Content = outterGrid;
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        stopwatch.Stop();
        timerLabel.Text = $"{stopwatch.ElapsedMilliseconds} ms";
        Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms to load this page.");
    }

    void AssignGridItems()
    {
        for (var a = 0; a < 25; a++)
        {
            for (var b = 0; b < 25; b++)
            {
                var box = new BoxView
                {
                    HorizontalOptions = LayoutOptions.Fill,
                    VerticalOptions = LayoutOptions.Fill,
                    Color = (b % 2) == 0 ? Colors.Red : Colors.Blue
                }.Row(a).Col(b);

                grid.Children.Add(box);
            }
        }
    }
}
