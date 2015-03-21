using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Model
{
    public class Media
    {
        public Media()
        { }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
