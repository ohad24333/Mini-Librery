using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Librery.Entities
{
    public class MiniBook
    {
        public MiniBook()
        {
        }

        public MiniBook(string id, string iSBN, string aouthor, string name)
        {
            Id = id;
            ISBN = iSBN;
            Aouthor = aouthor;
            Name = name;
        }

        public string Id { get; set; }
        public string ISBN { get; set; }
        public string Aouthor { get; set; }
        public string Name { get; set; }

    }
}
