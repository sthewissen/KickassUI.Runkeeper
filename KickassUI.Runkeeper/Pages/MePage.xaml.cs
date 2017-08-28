using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KickassUI.Runkeeper.Pages
{
    public partial class MePage : ContentPage
    {
        public MePage()
        {
            InitializeComponent();
        }

        void Handle_BadgeTapped(object sender, System.EventArgs e)
        {
            var item = sender as StackLayout;

            item.BackgroundColor = Color.FromHex("#1a767e");
        }
    }
}
