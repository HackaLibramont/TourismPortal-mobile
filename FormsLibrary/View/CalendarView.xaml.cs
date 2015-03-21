using FormsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsLibrary.View
{
    public partial class CalendarView : ContentPage
    {
        public CalendarView()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                listView.ItemsSource = Context.NewsList.OrderBy(i => i.Start_time);
                listView.ItemSelected += listView_ItemSelected;
            }
            catch
            {

            }
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                Events ev = e.SelectedItem as Events;
                if(ev != null)
                    await Navigation.PushAsync(new NavigationPage(new DetailsView(ev.Id)));
            }
            catch
            {

            }
        }
    }
}
