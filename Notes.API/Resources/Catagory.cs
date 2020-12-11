using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Resources
{
    public class Catagory
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public string Discription { get; set; }

        public List<int> Notes { get; } = new List<int>();

        public string Style { get; set; }

    }
}
