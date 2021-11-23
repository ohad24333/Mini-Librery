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
using System.Text.Json;

namespace Mini_Librery.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {



            InitializeComponent();
            SearchClientUserControl.BorrowingStarts += client => { panel1.Controls.Clear(); panel1.Controls.Add(new BorrowingUserControl(client)); };
            LibreryManegment.BookIsInvalidEvent += massege => MessageBox.Show(massege + " \nTry Again..");
            LibreryManegment.BooksListHasBeenReadFromJsonEvent += m => lblLowStripMassege.Text = "Updeted.";

            LibreryManegment.NewClientHasAddedEvent += (client, messege) => { panel1.Controls.Clear(); panel1.Controls.Add(new BorrowingUserControl(client)); };

            LibreryManegment.NewBorrowingHasAddedEvent += (borrowing, messege) =>
            {
                Book book = LibreryManegment.SearchBook(book => book.Id == borrowing.IdOfBook);
                Client client = LibreryManegment.SearchClient(client => client.Id == borrowing.IdOfClient);
                MessageBox.Show(
                    "THIS IS THE EMAIL......\n\n\n"+
                    $"Hello {client.FirstName} {client.LastName}!\nYou Just Borrowed The Book: {book.Name} By: {book.Aouthor} From The MiniLibrery.\n\n" +
                    $"We Just Wanted To Remind You That The Returning Book Date Is {borrowing.BorrowedDate.AddDays(14)}\n\n" +
                    "Thank You!");
            }; 
        }

        private void btnShowBooksList_Click(object sender, EventArgs e)
        {
           // LibreryManegment.ReadBooksFromJsonFile();
           // dgvBooksList.DataSource = LibreryManegment.AllBooksInLibrery;
        }

        private void serachForABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new SearchBookUserControl());
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel1.Controls.Add(new AddBookUserControl());
        }

        private void showBooksListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new BooksListUserControl());
        }

        private void showClientsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ClientListUserControl());
        }

        private void serachForAClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new SearchClientUserControl());
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AddClientUserControl());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showBorrowingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new BorrowingListUserControl());
        }

        private void serachForABoroowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new SearchBorrowingUserControl());
        }
    }
}
