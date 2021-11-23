using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mini_Librery.Entities;
using Mini_Librery.Logic;

namespace Mini_Librery.UI
{
    public partial class BooksListUserControl : UserControl
    {
        public BooksListUserControl()
        {
            LibreryManegment.BooksListHasBeenReadFromJsonEvent += m =>
            {
                BindingSource bs = new BindingSource() { DataSource = LibreryManegment.AllBooksInLibrery };
                dGVBookList.DataSource = bs;
            };

            InitializeComponent();
        }

        private void BooksListUserControl_Load(object sender, EventArgs e)
        {

            LibreryManegment.ReadBooksFromJsonFile();
        }

       







    }
}

