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
    public partial class AddClientUserControl : UserControl
    {

        public Client CurrentShownClient = null;
        
        public void ResetColumnColor()
        {
            txtFirstName.BackColor = Color.White;
            txtLastName.BackColor = Color.White;
            txtID.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtPhone.BackColor = Color.White;
        }

        public AddClientUserControl()
        {
            LibreryManegment.ClientColumnIsInvalid += column =>
            {
                switch (column)
                {
                    case ColumnsEnum.FirstName:
                        txtFirstName.BackColor = Color.Red;
                        break;
                    case ColumnsEnum.LastName:
                        txtLastName.BackColor = Color.Red;
                        break;
                    case ColumnsEnum.Id:
                        txtID.BackColor = Color.Red;
                        break;
                    case ColumnsEnum.Email:
                        txtEmail.BackColor = Color.Red;
                        break;
                    case ColumnsEnum.Phone:
                        txtPhone.BackColor = Color.Red;
                        break;
                    default:
                        break;
                }
               
            };
            LibreryManegment.NewClientHasAddedEvent += (client,messege) => MessageBox.Show(messege);
            LibreryManegment.NewClientHasAddedEvent += (client, messege) => MessageBox.Show("THis Is An Welcome Email");
            LibreryManegment.NewClientHasAddedEvent += (client, messege) => MakeInsertsControlReadonly();             
            LibreryManegment.NewClientHasAddedEvent += (client, messege) => MakeInsertsControlReadonly();
            LibreryManegment.ClientIvalidMassegeEvent += messege => MessageBox.Show(messege);
            

            

            InitializeComponent();
        }

        public void MakeInsertsControlReadonly()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtID.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            dTPDateOfBirth.Enabled = false;
            btnAddNewClient.Visible = false;
           
        }

        public void MakeInsertsControlEditable()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;    
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            dTPDateOfBirth.Enabled = true;
           
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            ResetColumnColor();
            if (LibreryManegment.ValidateClientProperties(txtFirstName.Text, txtLastName.Text, txtID.Text, txtEmail.Text,txtPhone.Text))
            {
                Client newClient = new Client(txtFirstName.Text, txtLastName.Text, txtID.Text, txtEmail.Text,txtPhone.Text, dTPDateOfBirth.Value);
                LibreryManegment.AddClientToList(newClient);
                CurrentShownClient = newClient;   
                
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
                CurrentShownClient.DOB  = dTPDateOfBirth.Value;
                
                LibreryManegment.SaveNewJsonFileOfClients();
                MakeInsertsControlReadonly();
                MessageBox.Show("Changes Saved.");
            }
        }

        private void AddClientUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
