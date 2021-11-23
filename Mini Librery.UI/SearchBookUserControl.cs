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
    public partial class SearchBookUserControl : UserControl
    {
        public SearchBookUserControl()
        {
           

            InitializeComponent();
        }

        public static List<Book> booksList = LibreryManegment.AllBooksInLibrery;

        public static Book CurrentShownBook = null;

        private void SearchUserControl_Load(object sender, EventArgs e)
        {
            comboxSearchOptions.Items.Add(SearchOptionsEnum.BookName);
            comboxSearchOptions.Items.Add(SearchOptionsEnum.Author);
            comboxSearchOptions.Items.Add(SearchOptionsEnum.ID);
        }

        public void MakeInsertsControlReadonly()
        {
            txtAuthor.Enabled = false;
            txtBookName.Enabled = false;
            txtNumberOfCopies.Enabled = false;
            txtNumberOfPages.Enabled = false;
            dTPDatePublished.Enabled = false;
           
            btnEdit.Visible = true;
        }

        public void MakeInsertsControlVisible()
        {
            txtAuthor.Visible = true;
            txtBookName.Visible = true;
            txtNumberOfCopies.Visible = true;
            txtNumberOfPages.Visible = true;
            dTPDatePublished.Visible = true;
          
            btnEdit.Visible = true;
        }

        public void MakeInsertsLabelsVisible()
        {
            lblAuthor.Visible = true;
            lblName.Visible = true;
            lblNumberOfCopies.Visible = true;
            lblNamberOfPages.Visible = true;
            lblDatePublished.Visible = true;
         
            btnEdit.Visible = true;
        }

        public void MakeInsertsControlEditable()
        {
            txtAuthor.Enabled = true;
            txtBookName.Enabled = true;
            txtNumberOfCopies.Enabled = true;
            txtNumberOfPages.Enabled = true;
            dTPDatePublished.Enabled = true;
            btnEdit.Visible = false;
            btnSaveChanges.Visible = true;
        }

      

     

        enum SearchOptionsEnum
        {
            BookName,
            Author,
            ID

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Book book = null;

            switch (comboxSearchOptions.Text)
            {
                case "BookName":
                    book = LibreryManegment.SearchBook(book => book.Name.Equals(txtSearchInsert.Text,StringComparison.OrdinalIgnoreCase));

                    break;

                case "Author":
                    book = LibreryManegment.SearchBook(book => book.Aouthor.Equals(txtSearchInsert.Text,StringComparison.OrdinalIgnoreCase));

                    break;
                case "ID":
                    book = LibreryManegment.SearchBook(book => book.Id == txtSearchInsert.Text);
                    break;            
            }

            if (book == null)
            {
                MessageBox.Show("Book Did Not Found");
            }
            else
            {
                MakeInsertsControlVisible();
                MakeInsertsLabelsVisible();
                txtAuthor.Text = book.Aouthor;
                txtBookName.Text = book.Name;
                txtNumberOfCopies.Text = book.NumberOfCopies.ToString();
                txtNumberOfPages.Text = book.NumberOfPages.ToString();
                txtID.Text = book.Id;
                dTPDatePublished.Value = book.DatePublished;
                CurrentShownBook = book;


            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            MakeInsertsControlEditable();
        }

        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            if (LibreryManegment.ValidateBookProperties("z" + txtAuthor.Text, txtBookName.Text, txtNumberOfCopies.Text, txtNumberOfPages.Text))
            {

                //LibreryManegment.AllBooksInLibrery.Where(x => x.Id == CurrentShownBook.Id).ToList().ForEach(b => 
                //{
                //        b.Aouthor = txtAuthor.Text;
                //        b.Name = txtBookName.Text;
                //        b.NumberOfPages = int.Parse(txtNumberOfPages.Text);
                //        b.NumberOfCopies = int.Parse(txtNumberOfCopies.Text);
                //});

                CurrentShownBook.Aouthor = txtAuthor.Text;
                CurrentShownBook.Name = txtBookName.Text;
                CurrentShownBook.NumberOfPages =int.Parse(txtNumberOfPages.Text);
                CurrentShownBook.NumberOfCopies = int.Parse(txtNumberOfCopies.Text);

                btnSaveChanges.Visible = false;
                btnEdit.Visible = true;               
                LibreryManegment.SaveNewJsonFileOfBooks();
                MakeInsertsControlReadonly();
                MessageBox.Show("Changes Saved.");
            }
        }
    }
}
