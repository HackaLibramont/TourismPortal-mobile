using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Utils
{
    public class WebRequestHelper
    {

        public static async Task<string> httpRequestGetString(HttpWebRequest request)
        {
            string received = string.Empty;

            using (HttpWebResponse response = (HttpWebResponse)(await Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null)))
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(responseStream))
                    {
                        received = await sr.ReadToEndAsync();
                    }
                }
            }

            return received;
        }

        public static async Task<HttpWebResponse> Get(HttpWebRequest request)
        {
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)(await Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null)))
                {
                    return response;
                }                
            }
            catch
            {
                return null;
            }
        }

    }
}
