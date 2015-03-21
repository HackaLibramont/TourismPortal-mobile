﻿using FormsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsLibrary.View
{
    public partial class ActivityListView : ContentPage
    {
        public ActivityListView()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                listView.ItemsSource = Context.InterestsList;
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
                Interests ev = e.SelectedItem as Interests;
                if (ev != null)
                    await Navigation.PushAsync(new NavigationPage(new InterestDetailsView(ev.Id)));
            }
            catch
            {

            }
        }



    }
}
