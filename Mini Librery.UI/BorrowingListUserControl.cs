using Mini_Librery.Entities;
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
    public partial class BorrowingListUserControl : UserControl
    {
        public BorrowingListUserControl()
        {
            InitializeComponent();
        }

        private void BorrowingListUserControl_Load(object sender, EventArgs e)
        {

            List<object> displayedValuesList = new List<object>();
            foreach (var borrow in LibreryManegment.AllBorrowings)
            {
                Client client = LibreryManegment.SearchClient(c => c.Id == borrow.IdOfClient);
                Book book = LibreryManegment.SearchBook(b => b.Id == borrow.IdOfBook);
                displayedValuesList.Add(new { CLientId = client.Id, ClientFirstName = client.FirstName, ClientLastName = client.LastName, BookId = book.Id, BookName = book.Name, borrow.BorrowedDate });
            }
            BindingSource bs = new BindingSource() { DataSource = displayedValuesList };
            dGVBorrowingList.DataSource = bs;
        }

        private void btnBooksThatDidntReturnedIn6Month_Click(object sender, EventArgs e)
        {
            List<object> displayedValuesList = new List<object>();

            foreach (var borrow in LibreryManegment.AllBorrowings)
            {
                if (borrow.BorrowedDate.AddMonths(6) <= DateTime.Now)
                {
                    Client client = LibreryManegment.SearchClient(c => c.Id == borrow.IdOfClient);
                    Book book = LibreryManegment.SearchBook(b => b.Id == borrow.IdOfBook);
                    displayedValuesList.Add(new
                    {
                        CLientId = client.Id,
                        ClientFirstName = client.FirstName,
                        ClientLastName = client.LastName,
                        BookId = book.Id,
                        BookName = book.Name,
                        borrow.BorrowedDate
                    });
                }
            }
            if (displayedValuesList.Count == 0)
            {
                MessageBox.Show("No Borrow Older Then 6 Month");
            }
            else
            {
                BindingSource bs = new BindingSource() { DataSource = displayedValuesList };
                dGVBorrowingList.DataSource = bs;
            }




        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            List<object> displayedValuesList = new List<object>();
            foreach (var borrow in LibreryManegment.AllBorrowings)
            {
                Client client = LibreryManegment.SearchClient(c => c.Id == borrow.IdOfClient);
                Book book = LibreryManegment.SearchBook(b => b.Id == borrow.IdOfBook);
                displayedValuesList.Add(new { CLientId = client.Id, ClientFirstName = client.FirstName, ClientLastName = client.LastName, BookId = book.Id, BookName = book.Name, borrow.BorrowedDate });
            }
            BindingSource bs = new BindingSource() { DataSource = displayedValuesList };
            dGVBorrowingList.DataSource = bs;
        }
    }
}
