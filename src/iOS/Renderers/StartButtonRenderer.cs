using System;
using CoreGraphics;
using Foundation;
using KickassUI.Runkeeper.Controls;
using KickassUI.Runkeeper.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(StartButton), typeof(StartButtonRenderer))]
namespace KickassUI.Runkeeper.iOS.Renderers
{
    public class StartButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var rootElement = e.NewElement as StartButton;

                if (Control != null)
                {
                    Control.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
                    Control.ImageEdgeInsets = new UIEdgeInsets(0, 0, 0, 0);
                    //Control.TitleEdgeInsets = new UIEdgeInsets(12, 3, 0, 0);

                    var labelAttributes = new UIStringAttributes()
                    {
                        ForegroundColor = rootElement.LabelColor.ToUIColor(),
                        Font = UIFont.FromName(rootElement.FontFamily, (nfloat)rootElement.LabelFontSize)
                    };

                    var titleAttributes = new UIStringAttributes()
                    {
                        ForegroundColor = rootElement.TextColor.ToUIColor(),
                        Font = UIFont.FromName(rootElement.FontFamily, (nfloat)rootElement.FontSize)
                    };

                    Control.TitleLabel.Lines = 2;

                    var pretty = new NSMutableAttributedString($"{rootElement.Label}\n{rootElement.Text}");

                    pretty.SetAttributes(labelAttributes, new NSRange(0, rootElement.Label.Length));
                    pretty.SetAttributes(titleAttributes, new NSRange(rootElement.Label.Length, rootElement.Text.Length));

                    Control.SetAttributedTitle(pretty, UIControlState.Normal);
                }
            }
        }
    }
}
