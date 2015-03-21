using FormsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsLibrary.View
{
    public partial class RoadMapView : ContentPage
    {
        private IList<Interests> _PoiList = new List<Interests>();

        public RoadMapView()
        {
            InitializeComponent();

            _PoiList = Context.InterestsList.Where(i => (i.Id == 1) || (i.Id == 2) || (i.Id == 3)).ToList();

            listView.ItemsSource = _PoiList;
        }
    }
}
