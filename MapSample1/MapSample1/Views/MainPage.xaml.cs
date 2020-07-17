using MapSample1.Models;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MapSample1.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        private int lastDisplayedId;
        private MapsPage mapInstance;

        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            lastDisplayedId = (int)MenuItemType.BrowseMaps;
        }

        public async Task NavigateFromMenu(int id)
        {
            if (lastDisplayedId != id)
            {
                switch (id)
                {
                    case (int)MenuItemType.BrowseMaps:
                        mapInstance = MapsPage.SelfInstance ?? new MapsPage();
                        Detail = new NavigationPage(mapInstance);               // Page will be instantiated once per app launch
                        break;
                    case (int)MenuItemType.About:
                        Detail = new NavigationPage(new AboutPage());
                        break;
                }
                lastDisplayedId = id;
            }

            if (Device.RuntimePlatform == Device.Android)
                await Task.Delay(100);

            IsPresented = false;
        }
    }
}