using FormsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsLibrary.View
{
    public partial class BlogView : ContentPage
    {
        public BlogView()
        {
            InitializeComponent(); 
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                listView.ItemsSource = Context.PostsList;
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
                Posts ev = e.SelectedItem as Posts;
                //if (ev != null)
                //    await Navigation.PushAsync(new NavigationPage(new DetailsView(ev.Id)));
            }
            catch
            {

            }
        }
    }
}
