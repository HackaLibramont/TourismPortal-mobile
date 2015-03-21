using FormsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsLibrary.View
{
    public partial class DetailsView : ContentPage
    {
        private Events _Event;
        
        public DetailsView()
        {
            InitializeComponent();
        }

        public DetailsView(int id)
        {
            InitializeComponent();
           
            _Event = Context.NewsList.FirstOrDefault(i => i.Id == id);

            if (_Event == null)
                return;
            
            TitleLabel.Text = _Event.Title;
            AddressLabel.Text = string.Concat(_Event.Street,"-",_Event.Zipcode,"-",_Event.City);
            StartDateLabel.Text = _Event.Start_time.ToString("dd/MM/yy H:mm");
            EndDateLabel.Text = _Event.End_time.ToString("dd/MM/yy H:mm");

            webView.Source = new HtmlWebViewSource() { Html = _Event.Excerpt };
        }



    }
}
