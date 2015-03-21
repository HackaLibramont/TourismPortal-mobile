using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Model
{
    public class City
    {
        public City()
        { }

        [JsonProperty("zip")]
        public int Zip {get; set;}

        [JsonProperty("city")]
        public string Name {get; set;}

        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

    }
}
