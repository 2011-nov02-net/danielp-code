using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Resources
{
    public class Catagories
    {
        private HashSet<Catagory> _catagories = new HashSet<Catagory>();

        public HashSet<Catagory> CatagoriesList { 
            get
            {
                return _catagories.ToHashSet();
            }
        }
    }
}
