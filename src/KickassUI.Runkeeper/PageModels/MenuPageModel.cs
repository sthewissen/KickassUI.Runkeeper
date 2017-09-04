using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using FormsToolkit;
using FreshMvvm;
using KickassUI.Runkeeper.Helpers;
using Xamarin.Forms;

namespace KickassUI.Runkeeper.PageModels
{
    public class MenuPageModel : FreshBasePageModel
    {
        public ICommand NavigateCommand { get; set; }

        public List<MenuItem> MenuItems { get; set; }
        public MenuItem SelectedItem { get; set; }

        public MenuPageModel()
        {
            NavigateCommand = new Command(NavigateToPageModel);

            MenuItems = new List<MenuItem>();

            MenuItems.Add(new MenuItem() { Value = "Start", Label = "Start", Image = "start.png" });
            MenuItems.Add(new MenuItem() { Value = "Me", Label = "Me (Xamarin Forms version)", Image = "me.png" });
            MenuItems.Add(new MenuItem() { Value = "MeClone", Label = "Me (Runkeeper clone)", Image = "me.png" });
        }

        void NavigateToPageModel()
        {
            MessagingService.Current.SendMessage<string>(MessageKeys.NavigationTriggered, SelectedItem.Value);
        }
    }

    public class MenuItem
    {
        public string Label { get; set; }
        public string Image { get; set; }
        public string Value { get; set; }
    }
}