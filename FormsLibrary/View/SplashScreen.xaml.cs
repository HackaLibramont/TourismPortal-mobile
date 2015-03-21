using FormsLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsLibrary.View
{
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
            Load();
        }

        private async void Load()
        {
            try
            {
                await DataHelper.LoadData();
                await Navigation.PushAsync(new NavigationPage(new MenuView()));
            }
            catch (Exception ex)
            {

            }
        }
    }
}
