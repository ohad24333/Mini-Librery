using Mini_Librery.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Librery.UI
{
    public partial class ClientListUserControl : UserControl
    {
        public ClientListUserControl()
        {
            InitializeComponent();
        }

        private void ClientListUserControl_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource() { DataSource = LibreryManegment.AllClients };
            dGVClientList.DataSource = bs;
        }
    }
}
