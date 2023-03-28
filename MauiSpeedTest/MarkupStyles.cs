using System;
using CSharpForMarkup;

namespace MauiSpeedTest
{
	public static class MarkupStyles
	{
        public static Style<Button> ButtonStyle = new Style<Button>(
            (Button.StyleProperty, CenterLayoutStyle),
            (Button.FontSizeProperty, 20),
            (Button.FontAttributesProperty, FontAttributes.Bold),
            (Button.BackgroundColorProperty, Colors.Purple),
            (Button.TextColorProperty, Colors.White),
            (Button.HeightRequestProperty, 50),
            (Button.CornerRadiusProperty, 10),
            (Button.PaddingProperty, new Thickness(10, 0)));

        public static Style<View> CenterLayoutStyle = new Style<View>(
             (View.HorizontalOptionsProperty, LayoutOptions.Center),
             (View.VerticalOptionsProperty, LayoutOptions.Center));

        public static Style<Layout> FillLayoutStyle = new Style<Layout>(
             (Layout.HorizontalOptionsProperty, LayoutOptions.Fill),
             (Layout.VerticalOptionsProperty, LayoutOptions.Fill));

        public static Style<Label> TimerLabelStyle = new Style<Label>(
            (Label.StyleProperty, CenterLayoutStyle),
            (Label.VerticalTextAlignmentProperty, TextAlignment.Center),
            (Label.HorizontalTextAlignmentProperty, TextAlignment.Center),
            (Label.FontSizeProperty, 60));

        public static Style<Label> CellLabelStyle = new Style<Label>(
            (Label.StyleProperty, CenterLayoutStyle),
            (Label.TextColorProperty, Colors.White),
            (Label.BackgroundColorProperty, Colors.Transparent),
            (Label.VerticalTextAlignmentProperty, TextAlignment.Center),
            (Label.HorizontalTextAlignmentProperty, TextAlignment.Center),
            (Label.FontSizeProperty, 25));
    }
}

