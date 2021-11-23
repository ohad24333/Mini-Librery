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
    public partial class AddBookUserControl : UserControl
    {
        public AddBookUserControl()
        {
            LibreryManegment.NewBookHasAddedEvent += m => MessageBox.Show(m);
            LibreryManegment.NewBookHasAddedEvent += m => MakeInsertsControlReadonly();

            InitializeComponent();
        }

        public static Book CurrentShownBook { get; set; }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (LibreryManegment.ValidateBookProperties(txtAuthor.Text, txtBookName.Text, txtNumberOfCopies.Text, txtNumberOfPages.Text))
            {
                Book newBook = new Book(txtAuthor.Text, txtNumberOfCopies.Text, int.Parse(txtBookName.Text), int.Parse(txtNumberOfPages.Text), 0, dTPDatePublished.Value);
                LibreryManegment.AddABookToList(newBook);
                CurrentShownBook = newBook;
                lblID.Visible = true;
                txtID.Visible = true;
                txtID.Text = newBook.Id;
                
            }
        }

        public void MakeInsertsControlReadonly()
        {
            txtAuthor.Enabled = false;
            txtNumberOfCopies.Enabled = false;
            txtNumberOfPages.Enabled = false;
            txtBookName.Enabled = false;
            dTPDatePublished.Enabled = false;
            btnAddNewBook.Visible = false;
            btnEdit.Visible = true;
        }

        public void MakeInsertsControlEditable()
        {
            txtAuthor.Enabled = true;
            txtNumberOfCopies.Enabled = true;
            txtNumberOfPages.Enabled = true;
            txtBookName.Enabled = true;
            dTPDatePublished.Enabled = true;
            btnEdit.Visible = false;
            btnSaveChanges.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MakeInsertsControlEditable();

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (LibreryManegment.ValidateBookProperties("z"+ txtAuthor.Text, txtNumberOfCopies.Text, txtBookName.Text, txtNumberOfPages.Text))
            {
                CurrentShownBook.Aouthor = txtAuthor.Text;
                CurrentShownBook.Name = txtNumberOfCopies.Text;
                CurrentShownBook.NumberOfPages = int.Parse(txtBookName.Text);
                CurrentShownBook.NumberOfCopies = int.Parse(txtNumberOfPages.Text);
                btnSaveChanges.Visible = false;
                btnEdit.Visible = true;
                LibreryManegment.SaveNewJsonFileOfClients();
                MakeInsertsControlReadonly();
                MessageBox.Show("Changes Saved.");
            }
        }

     
    }
}
