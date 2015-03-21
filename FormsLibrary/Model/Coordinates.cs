using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Model
{
    public class Coordinates
    {
        public Coordinates()
        { }

        [JsonProperty("latitude")]
        public float Lat {get; set;}

        [JsonProperty("longitude")]
        public float Long {get; set;}

    }
}
