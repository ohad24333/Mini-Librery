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
    public partial class SearchClientUserControl : UserControl
    {
       

        public static Action<Client> BorrowingStarts;

        Client CurrentShownClient;

        public SearchClientUserControl()
        {
            InitializeComponent();
        }


        private void SerachClientUserControl_Load(object sender, EventArgs e)
        {
            comboxSearchOptions.Items.Add("Id");
            comboxSearchOptions.Items.Add("Phone");
            comboxSearchOptions.Items.Add("Email");
        }

        #region Visible And Editable
        public void MakeInsertsControlEditable()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            dTPDateOfBirth.Enabled = true;
            btnEdit.Visible = false;
            btnSaveChanges.Visible = true;
        }

        public void MakeInsertsControlVisible()
        {
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtID.Visible = true;
            txtEmail.Visible = true;
            txtPhone.Visible = true;
            dTPDateOfBirth.Visible = true;
            btnEdit.Visible = true;
        }

        public void MakeInsertsLabelsVisible()
        {
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblID.Visible = true;
            lblEmail.Visible = true;
            lblPhone.Visible = true;
            lblDateOfBirth.Visible = true;

        }

        public void MakeInsertsControlReadonly()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtID.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            dTPDateOfBirth.Enabled = false;        
            btnEdit.Visible = true;
        }

        #endregion

        #region Button Click Methods Events
        private void btnSearch_Click(object sender, EventArgs e)
        {

            Client client = null;

            switch (comboxSearchOptions.Text)
            {
                case "Id":
                    client = LibreryManegment.SearchClient(c => c.Id == txtSearchInsert.Text);
                    break;

                case "Phone":
                    client = LibreryManegment.SearchClient(c => c.Phone == txtSearchInsert.Text);

                    break;
                case "Email":
                    client = LibreryManegment.SearchClient(c => c.Email.Equals(txtSearchInsert.Text, StringComparison.OrdinalIgnoreCase));
                    break;
            }

            if (client == null)
            {
                MessageBox.Show("Client Did Not Found");
            }
            else
            {
                MakeInsertsControlVisible();
                MakeInsertsLabelsVisible();
                txtFirstName.Text = client.FirstName;
                txtLastName.Text = client.LastName;
                txtEmail.Text = client.Email;
                txtPhone.Text = client.Phone;
                txtID.Text = client.Id;
                dTPDateOfBirth.Value = client.DOB;
                CurrentShownClient = client;
                btnAddBorrowing.Visible = true;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MakeInsertsControlEditable();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (LibreryManegment.ValidateClientProperties(txtFirstName.Text, txtLastName.Text, ("123456789"), txtEmail.Text, txtPhone.Text))
            {
                CurrentShownClient.FirstName = txtFirstName.Text;
                CurrentShownClient.LastName = txtLastName.Text;
                CurrentShownClient.Id = txtID.Text;
                CurrentShownClient.Email = txtEmail.Text;
                CurrentShownClient.Phone = txtPhone.Text;
                CurrentShownClient.DOB = dTPDateOfBirth.Value;
                btnSaveChanges.Visible = false;
                btnEdit.Visible = true;
                LibreryManegment.SaveNewJsonFileOfClients();
                MakeInsertsControlReadonly();
                MessageBox.Show("Changes Saved.");
            }
        }


        #endregion

        private void btnAddBorrowing_Click(object sender, EventArgs e)
        {

            BorrowingStarts(CurrentShownClient);


        }
    }
}
