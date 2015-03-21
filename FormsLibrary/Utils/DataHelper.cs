using FormsLibrary.Model;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Services.Geolocation;

namespace FormsLibrary.Utils
{
    public class DataHelper
    {
        private static string CST_URLBASE = "http://tourism-portal.be";

        public static string ApiBase
        {
            get
            {
                return string.Concat(CST_URLBASE, "/api/");
            }
        }

        public async static Task LoadData()
        {
            try
            {
                Position pos = await GetGeoLocation();
                await LoadNews();
                //await LoadPages();
                await LoadPosts();
                await LoadInterests();
                await LoadCategories();
            }
            catch
            {
                
            }
        }

        public async static Task<Position> GetGeoLocation()
        {
            try
            {
                IGeolocator locator = DependencyService.Get<IGeolocator>();                 
                Position pos = await locator.GetPositionAsync(10000);
                return pos;
            }
            catch                
            {
                return null;
            }
        }

        public async static Task LoadPages()
        {
            try
            {
                HttpWebRequest client = HttpWebRequest.CreateHttp(string.Concat(ApiBase, "pages.json"));

                string json = await WebRequestHelper.httpRequestGetString(client);

                IList<FormsLibrary.Model.Page> pageList = JsonConvert.DeserializeObject<IList<FormsLibrary.Model.Page>>(json);
                Context.PageList = pageList;
            }
            catch
            {

            }
        }

        public async static Task LoadPosts()
        {
            try
            {
                HttpWebRequest client = HttpWebRequest.CreateHttp(string.Concat(ApiBase, "posts.json"));

                string json = await WebRequestHelper.httpRequestGetString(client);

                IList<FormsLibrary.Model.Posts> postsList = JsonConvert.DeserializeObject<IList<FormsLibrary.Model.Posts>>(json);
                Context.PostsList = postsList;
            }
            catch
            {

            }
        }

        public async static Task LoadInterests()
        {
            try
            {
                HttpWebRequest client = HttpWebRequest.CreateHttp(string.Concat(ApiBase, "interests.json"));

                string json = await WebRequestHelper.httpRequestGetString(client);

//                string json = @"[{id: 1,      name: ""chez Nous  "",      description: ""chez Nous on se fout pas de vous."",      address: ""rue des déportés 17"",
//                         zip: 6700,      mobile: ""0498685687"",phone: ""063223363"",      email: ""cedric@studio-sept.be"",      website: ""http://www.studio-sept.be"",
//                         coordinates:  { latitude: 5.34,longitude: 55.22},category: {id: 1,label: ""Hébergement""},city: {zip: 6700,city: ""Arlon"", coordinates: { latitude: 5.5,longitude: 55.5}},
//                         criteria: [{id: 1,label: ""On parle chinois""}],pictures: [{url: ""http://pivotmedia.tourismewallonie.be/pivot/ANX-09-000JYS/ANX-09-000JYS.JPG""}],
//                         videos: [{url: ""http://foo.com/video.mp3""}]}]";


                IList<FormsLibrary.Model.Interests> interestList = JsonConvert.DeserializeObject<IList<FormsLibrary.Model.Interests>>(json);
                Context.InterestsList = interestList;
            }
            catch
            {

            }
        }

        public async static Task LoadInterests(int categorieID)
        {
            try
            {
                HttpWebRequest client = HttpWebRequest.CreateHttp(string.Concat(ApiBase, categorieID.ToString() ,"/interests.json"));

                string json = await WebRequestHelper.httpRequestGetString(client);

                IList<FormsLibrary.Model.Interests> interestList = JsonConvert.DeserializeObject<IList<FormsLibrary.Model.Interests>>(json);
                Context.InterestsList = interestList;
            }
            catch
            {

            }
        }

        public async static Task LoadCategories()
        {
            try
            {
                HttpWebRequest client = HttpWebRequest.CreateHttp(string.Concat(ApiBase, "posts.json"));

                string json = await WebRequestHelper.httpRequestGetString(client);

                IList<FormsLibrary.Model.Categorie> categoriesList = JsonConvert.DeserializeObject<IList<FormsLibrary.Model.Categorie>>(json);
                Context.CategoriesList = categoriesList;
            }
            catch
            {

            }
        }

        public async static Task LoadNews()
        {
            try
            {
                HttpWebRequest client = HttpWebRequest.CreateHttp(string.Concat(ApiBase, "events.json"));

                string json = await WebRequestHelper.httpRequestGetString(client);

                IList<Events> eventList = JsonConvert.DeserializeObject<IList<Events>>(json);
                Context.NewsList = eventList;
            }
            catch
            {

            }
        }

    }
}
