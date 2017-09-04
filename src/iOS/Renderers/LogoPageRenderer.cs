using System;
using System.Linq;
using CoreGraphics;
using KickassUI.Runkeeper.Controls;
using KickassUI.Runkeeper.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LogoPage), typeof(LogoPageRenderer))]
namespace KickassUI.Runkeeper.iOS.Renderers
{
    public class LogoPageRenderer : ContentPageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            if (NavigationController != null)
            {
                NavigationController.NavigationBar.Frame = new CGRect(0, 0, this.View.Frame.Size.Width, 75.0);

                // Move the title up a bit, it's not centered anymore due to our custom height.
                NavigationController.NavigationBar.SetTitleVerticalPositionAdjustment(-5, UIBarMetrics.Default);

                // Move the toolbaritems up too.
                var navigationItem = NavigationController.TopViewController.NavigationItem;
                var leftNativeButtons = (navigationItem.LeftBarButtonItems ?? new UIBarButtonItem[] { }).ToList();
                var rightNativeButtons = (navigationItem.RightBarButtonItems ?? new UIBarButtonItem[] { }).ToList();

                leftNativeButtons.ForEach(x => x.ImageInsets = new UIEdgeInsets(-8, 0, 0, 0));
                rightNativeButtons.ForEach(x => x.ImageInsets = new UIEdgeInsets(-8, 0, 0, 0));
            }
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var image = UIImage.FromBundle("logo.png");
            var imageView = new UIImageView(new CGRect(0, 0, 40, 40));

            imageView.ContentMode = UIViewContentMode.ScaleAspectFit;
            imageView.Image = image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);

            if (NavigationController != null)
            {
                NavigationController.TopViewController.NavigationItem.TitleView = imageView;
            }
        }
    }
}
