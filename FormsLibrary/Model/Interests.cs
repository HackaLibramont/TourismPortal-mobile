using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Model
{
    public class Interests
    {
        public Interests()
        { }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("zip")]
        public int? Zip { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("category")]
        public Categorie Category { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("criteria")]
        public IList<Criteria> Criteria { get; set; }

        [JsonProperty("pictures")]
        public IList<Media> Pictures { get; set; }

        [JsonProperty("videos")]
        public IList<Media> Videos { get; set; }
    }
}
