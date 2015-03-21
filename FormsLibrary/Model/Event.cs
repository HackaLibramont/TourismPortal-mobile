using FormsLibrary.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FormsLibrary.Model
{
    public class Events
    {      

        public Events()
        {}

        [JsonProperty("id")]
        public int Id {get; set;}

        [JsonProperty("title")]
        public string Title {get; set;}

        [JsonProperty("excerpt")]
        public string Excerpt {get; set;}

        [JsonProperty("published_at")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime Published_at {get; set;}

        [JsonProperty("start_time")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime Start_time {get; set;}

        [JsonProperty("end_time")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime End_time {get; set;}

        [JsonProperty("street")]
        public string Street {get; set;}

        [JsonProperty("zipcode")]
        public string Zipcode {get; set;}

        [JsonProperty("city")]
        public string City {get; set;}

        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

    }
}
