using System;
using System.Collections.ObjectModel;
using FreshMvvm;
using KickassUI.Runkeeper.Models;

namespace KickassUI.Runkeeper.PageModels
{
    public class MePageModel : FreshBasePageModel
    {
        public ObservableCollection<Stats> Statistics { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            Statistics = new ObservableCollection<Stats>();

            Statistics.Add(new Stats { Title = "Kilometers", Label1 = "August", Label2 = "July", Value1 = "4,2", Value2 = "24,4" });
            Statistics.Add(new Stats { Title = "Average Pace (Min/Km)", Label1 = "August", Label2 = "July", Value1 = "4:34", Value2 = "5:02" });
            Statistics.Add(new Stats { Title = "Activities", Label1 = "August", Label2 = "July", Value1 = "1", Value2 = "6" });
            Statistics.Add(new Stats { Title = "Calories Burned", Label1 = "August", Label2 = "July", Value1 = "341", Value2 = "1.954" });
            Statistics.Add(new Stats { Title = "Elevation Climb (M)", Label1 = "August", Label2 = "July", Value1 = "29,3", Value2 = "221,1" });
            Statistics.Add(new Stats { Title = "Time Spent", Label1 = "August", Label2 = "July", Value1 = "19:22", Value2 = "2:02:39" });
        }
    }
}
