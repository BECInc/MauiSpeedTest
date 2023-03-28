using CSharpForMarkup;

namespace MauiSpeedTest;

public class ListTestPage : ContentPage
{
	private List<Thingy> thingies;

	public ListTestPage()
	{
		thingies = new();
		for(var i = 0; i < 25; i++)
		{
			thingies.Add(new Thingy($"Hello{i}", $"SubHello{i}"));
		}

		Content = CreatePageContent();
	}

	Grid CreatePageContent()
		=> new Grid
		{
			Style = MarkupStyles.FillLayoutStyle,
			RowDefinitions =
			{
				new RowDefinition { Height = GridLength.Star }
			},
			Children =
			{
				new ListView ()
				{
					Style = MarkupStyles.FillLayoutStyle,
					RowHeight = 100,
					SeparatorVisibility = SeparatorVisibility.None,
					Footer = new Label(),
                    ItemsSource = thingies,
                    ItemTemplate =  new CustomTemplateSelector()
                }
            }
				
		};

    private class CustomTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var cell = new CustomCell((Thingy) item);
            return new DataTemplate(() => cell);
        }
    }
}
