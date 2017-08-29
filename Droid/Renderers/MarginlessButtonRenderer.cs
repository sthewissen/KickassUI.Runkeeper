using System;
using KickassUI.Runkeeper.Controls;
using KickassUI.Runkeeper.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(MarginlessButtonRenderer))]
namespace KickassUI.Runkeeper.Droid.Renderers
{
    public class MarginlessButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // remove default background image
                Control.Background = null;
                Control.SetBackgroundColor(Element.BackgroundColor.ToAndroid());
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "BackgroundColor")
            {
                // You have to set background color here again, because the background color can be changed later.
                Control.SetBackgroundColor(Element.BackgroundColor.ToAndroid());
            }
        }
    }
}