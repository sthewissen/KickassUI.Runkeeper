using System;
using System.Collections.Generic;
using KickassUI.Runkeeper.Controls;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace KickassUI.Runkeeper.Pages
{
    public partial class StartPage : LogoPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            // Set the map to your current location.
            var locator = CrossGeolocator.Current;
            Plugin.Geolocator.Abstractions.Position position = await locator.GetPositionAsync(TimeSpan.FromSeconds(20), null, true);

            if (position != null)
            {
                mapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Distance.FromMiles(1)).WithZoom(16));
            }
        }
    }
}
