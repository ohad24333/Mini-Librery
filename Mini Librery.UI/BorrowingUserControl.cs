using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mini_Librery.Logic;
using Mini_Librery.Entities;

namespace Mini_Librery.UI
{
    public partial class BorrowingUserControl : UserControl
    {
        
        
        public BorrowingUserControl(Client client)
        {
            InitializeComponent();




            LibreryManegment.NewBorrowingHasAddedEvent += (client,messege) => MessageBox.Show(messege);
            CurrentClientShown = client;
            dTPStartOfBorrowing.MaxDate = DateTime.Now.AddDays(2);
            dTPStartOfBorrowing.MinDate = DateTime.Now;
            var comboxBookNamesQuery  = LibreryManegment.AllBooksInLibrery.Where(book =>
            {
                return book.NumberOfCopies > 0 && book.NumberOfCopies > book.NumberOfBorrowedOut;
            }).Select(book => book.Name);

            foreach (var item in comboxBookNamesQuery)
            {
                comboxBookName.Items.Add(item) ;
            }
        }

        public Client CurrentClientShown { get; set; }
        
     
        private void BorrowingUserControl_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource() {DataSource = CurrentClientShown.BorrowedBooksList };
            dGVBookStiilWithClient.DataSource = bs;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblReturningDateValue.Text = dTPStartOfBorrowing.Value.AddDays(14).ToLongDateString();
        }

        private void btnAddNewBookToBorowingList_Click(object sender, EventArgs e)
        {
            Book bookFromList = LibreryManegment.SearchBook(book => book.Name == comboxBookName.SelectedItem.ToString());

            bookFromList.NumberOfBorrowedOut++;

            MiniBook miniBook = new MiniBook() { Aouthor = bookFromList.Aouthor, Name = bookFromList.Name, Id = bookFromList.Id, ISBN = bookFromList.ISBN };
            CurrentClientShown.BorrowedBooksList.Add(miniBook);

            LibreryManegment.AddBorrowToList(new Borrowing() { IdOfBook = bookFromList.Id, IdOfClient = CurrentClientShown.Id, BorrowedDate = dTPStartOfBorrowing.Value});

            BindingSource bindingSource = new BindingSource() { DataSource = CurrentClientShown.BorrowedBooksList };
            dGVBookStiilWithClient.DataSource = bindingSource;
 
        }
    }
}
