using System;
using Android.App;
using KickassUI.Runkeeper.Droid.Renderers;
using KickassUI.Runkeeper.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(StartPage), typeof(StartPageRenderer))]
namespace KickassUI.Runkeeper.Droid.Renderers
{
    public class StartPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
        }
    }
}
