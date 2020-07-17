using MapSample1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MapSample1.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MapsPage : ContentPage
    {
        public static MapsPage SelfInstance;

        public MapsPage()
        {
            InitializeComponent();

            SelfInstance = this;
            BindingContext = new MapsViewModel();
        }
    }
}