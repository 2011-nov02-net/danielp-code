using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Resources
{
    public class Note
    {
        public int Id { get; private set; }

        public DateTime Created { get; }

        public Author Author { get; }

        public Catagory Catagory { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
