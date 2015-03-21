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
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            try
            {
                AreaSizeSelector.Items.Add("5");
                AreaSizeSelector.Items.Add("10");
                AreaSizeSelector.Items.Add("15");
                AreaSizeSelector.Items.Add("20");
                AreaSizeSelector.Items.Add("30");

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

            }
            catch
            {

            }
        }
        
    }
}
