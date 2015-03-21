using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Model
{
    public class MenuItem
    {
        private string _Name = string.Empty;
        private Uri _Uri = null;

        public MenuItem(string name)
        {
            _Name = name;
        }

        public MenuItem(string name, Uri uri)
        {
            _Name = name;
            _Uri = uri;
        }

        public string Name
        {
            get
            {
                return _Name;
            }
        }

        public Uri ImageUri
        {
            get
            {
                return _Uri;
            }
        }

    }
}
