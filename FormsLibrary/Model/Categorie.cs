using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Model
{
    public class Categorie
    {
        public Categorie()
        { }

        [JsonProperty("id")]
        public int Id {get; set;}

        [JsonProperty("label")]
        public string Label {get; set;}

        [JsonProperty("children")]
        public IList<Categorie> SubCategories { get; set; }


    }
}
