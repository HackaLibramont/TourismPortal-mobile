using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FormsLibrary.View
{
    public partial class SettingsView : ContentPage
    {
        public SettingsView()
        {
            InitializeComponent();
            try
            {
                AreaSizeSelector.Items.Add("1");
                AreaSizeSelector.Items.Add("5");
                AreaSizeSelector.Items.Add("10");
                AreaSizeSelector.Items.Add("20");                

                if(App.Area == 1)
                {
                    AreaSizeSelector.SelectedIndex = 0;
                }
                else if(App.Area == 5)
                {
                    AreaSizeSelector.SelectedIndex = 1;
                }
                else if(App.Area == 10)
                {
                    AreaSizeSelector.SelectedIndex = 2;
                }
                else if(App.Area == 20)
                {
                    AreaSizeSelector.SelectedIndex = 3;
                }

                AreaSizeSelector.SelectedIndexChanged += AreaSizeSelector_SelectedIndexChanged;
            }
            catch
            {

            }
        }        

        private void AreaSizeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Picker p = sender as Picker;
                
                int val = p.SelectedIndex;
                if (val == 0)
                {
                    App.Area = 1;
                }
                else if (val == 1)
                {
                    App.Area = 5;
                }
                else if (val == 2)
                {
                    App.Area = 10;
                }
                else if (val == 3)
                {
                    App.Area = 20;
                }

            }
            catch
            {

            }
        }
        
    }
}
