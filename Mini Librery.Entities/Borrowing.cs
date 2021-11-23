using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Librery.Entities
{
    public class Borrowing
    {
        public string IdOfBook { get; set; }
        public string IdOfClient { get; set; }
        public DateTime BorrowedDate { get; set; }

    }
}
