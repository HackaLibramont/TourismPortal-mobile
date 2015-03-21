using FormsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsLibrary.View
{
    public partial class MenuView : ContentPage
    {
        private IList<FormsLibrary.Model.MenuItem> _MenuList = new List<FormsLibrary.Model.MenuItem>();

        public MenuView()
        {
            InitializeComponent();

            ToolbarItems.Add(new ToolbarItem
            {
                Name = "Paramètres",
                Order = ToolbarItemOrder.Primary,
                Icon = new FileImageSource() { File = "Image/cog2.png" },
                Command = new Command(() => Navigation.PushAsync(new SettingsView()))
            });
        }

        public async void ButtonClicked1(object sender, EventArgs ea)
        {
            await Navigation.PushAsync(new NavigationPage(new ActivityListView()));
        }

        public async void ButtonClicked2(object sender, EventArgs ea)
        {
            await Navigation.PushAsync(new NavigationPage(new CalendarView()));
        }

        public async void ButtonClicked3(object sender, EventArgs ea)
        {
            await Navigation.PushAsync(new NavigationPage(new RoadMapView()));
        }

        public async void ButtonClicked4(object sender, EventArgs ea)
        {
            await Navigation.PushAsync(new NavigationPage(new WeatherView()));
        }

        public async void ButtonClicked5(object sender, EventArgs ea)
        {
            await Navigation.PushAsync(new NavigationPage(new BlogView()));
        }

        public void ButtonClicked6(object sender, EventArgs ea)
        {
            //Go to external browser
            Device.OpenUri(new Uri("http://tourism-portal.be/"));
        }

        public void LaunchMapApp(Coordinates place)
        {
            #if __IOS__
              var request = string.Format("http://maps.apple.com/maps?q={2}@{0},{1}", 
                place.Location.Latitude, place.Location.Longitude, Uri.EscapeUriString(place.Name));
              //Device.OpenUri(new Uri(request));
              MonoTouch.UIKit.UIApplication.SharedApplication.OpenUrl(new MonoTouch.Foundation.NSUrl(request));
            #elif __ANDROID__
              var request = string.Format("geo:0,0?q={0},{1}({2})", 
                place.Location.Latitude, place.Location.Longitude, Uri.EscapeUriString(place.Name));
              Device.OpenUri(new Uri(request));
            #elif WINDOWS_PHONE
              var request = string.Format("bingmaps:?collection=point.{0}_{1}_{2}", 
                place.Location.Latitude, place.Location.Longitude, Uri.EscapeUriString(place.Name));
              //Device.OpenUri(new Uri(request));
              Windows.System.Launcher.LaunchUriAsync(new Uri(request));
            #else
                        throw new Exception("No device type compile-time directive found");
            #endif
        }
    }
}
