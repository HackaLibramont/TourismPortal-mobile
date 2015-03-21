using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Model
{
    public static class Context
    {
        public static IList<Events> NewsList { get; set; }
        public static IList<Page> PageList { get; set; }
        public static IList<Posts> PostsList { get; set; }
        public static IList<Categorie> CategoriesList { get; set; }
        public static IList<Interests> InterestsList { get; set; }


    }
}
