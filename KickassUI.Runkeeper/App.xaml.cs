using System.Linq;
using FreshMvvm;
using KickassUI.Runkeeper.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace KickassUI.Runkeeper
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
                var tabs = new FreshTabbedNavigationContainer("RunkeeperTabs");

                tabs.AddTab<MePageModel>("Me", "me.png");
                tabs.AddTab<MyPlanPageModel>("My Plan", "myplan.png");
                tabs.AddTab<StartPageModel>("Start", "start.png");
                tabs.AddTab<FriendsPageModel>("Friends", "friends.png");
                tabs.AddTab<ChallengesPageModel>("Challenges", "challenges.png");

                // Set the selected tab to the middle one.
                tabs.SwitchSelectedRootPageModel<StartPageModel>();

                MainPage = tabs;
            }
            else
            {
                var navContainer = new FreshMasterDetailNavigationContainer();

                navContainer.Init("Menu", "hamburger.png");
                navContainer.AddPage<StartPageModel>("Start");
                navContainer.AddPage<MePageModel>("Me");
                navContainer.AddPage<MePageModel>("Me Cloned");

                MainPage = navContainer;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
