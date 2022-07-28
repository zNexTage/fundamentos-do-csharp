using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAuthor.Entities
{
    internal class Author
    {
        public int id { get; }
        public string name { get; set; }
        public string description { get; set; }

        public Author(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public Author(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
