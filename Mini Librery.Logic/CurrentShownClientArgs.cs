using Mini_Librery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Librery.Logic
{
    public class CurrentShownClientArgs : EventArgs
    {
        public Client  Client { get; set; }


    }
}
