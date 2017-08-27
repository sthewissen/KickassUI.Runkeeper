using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace KickassUI.Runkeeper.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            Xamarin.FormsMaps.Init();

            UITabBar.Appearance.BarTintColor = UIColor.White;
            UITabBar.Appearance.TintColor = Color.FromHex("#2dc9d7").ToUIColor();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
