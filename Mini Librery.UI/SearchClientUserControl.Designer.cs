
namespace Mini_Librery.UI
{
    partial class SearchClientUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtSearchInsert = new System.Windows.Forms.TextBox();
            this.comboxSearchOptions = new System.Windows.Forms.ComboBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblSearchAClient = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dTPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddBorrowing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChanges.Location = new System.Drawing.Point(469, 400);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(133, 39);
            this.btnSaveChanges.TabIndex = 45;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(35, 400);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 39);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(382, 109);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(220, 23);
            this.txtLastName.TabIndex = 42;
            this.txtLastName.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(382, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 23);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(382, 166);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 23);
            this.txtID.TabIndex = 40;
            this.txtID.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(382, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 23);
            this.txtFirstName.TabIndex = 39;
            this.txtFirstName.Visible = false;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.Location = new System.Drawing.Point(273, 319);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(131, 25);
            this.lblDateOfBirth.TabIndex = 33;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            this.lblDateOfBirth.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(273, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 25);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(273, 109);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(108, 25);
            this.lblLastName.TabIndex = 36;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(273, 166);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 25);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(273, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(111, 25);
            this.lblFirstName.TabIndex = 38;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(133, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnter.Location = new System.Drawing.Point(29, 195);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(53, 21);
            this.lblEnter.TabIndex = 31;
            this.lblEnter.Text = "Enter:";
            // 
            // txtSearchInsert
            // 
            this.txtSearchInsert.Location = new System.Drawing.Point(88, 193);
            this.txtSearchInsert.Name = "txtSearchInsert";
            this.txtSearchInsert.Size = new System.Drawing.Size(135, 23);
            this.txtSearchInsert.TabIndex = 30;
            // 
            // comboxSearchOptions
            // 
            this.comboxSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSearchOptions.FormattingEnabled = true;
            this.comboxSearchOptions.Location = new System.Drawing.Point(87, 129);
            this.comboxSearchOptions.Name = "comboxSearchOptions";
            this.comboxSearchOptions.Size = new System.Drawing.Size(136, 23);
            this.comboxSearchOptions.TabIndex = 29;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBy.Location = new System.Drawing.Point(29, 129);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(28, 21);
            this.lblBy.TabIndex = 28;
            this.lblBy.Text = "By";
            // 
            // lblSearchAClient
            // 
            this.lblSearchAClient.AutoSize = true;
            this.lblSearchAClient.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchAClient.Location = new System.Drawing.Point(35, 55);
            this.lblSearchAClient.Name = "lblSearchAClient";
            this.lblSearchAClient.Size = new System.Drawing.Size(209, 37);
            this.lblSearchAClient.TabIndex = 27;
            this.lblSearchAClient.Text = "Search A Client:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(273, 271);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 25);
            this.lblPhone.TabIndex = 46;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(382, 276);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 23);
            this.txtPhone.TabIndex = 47;
            this.txtPhone.Visible = false;
            // 
            // dTPDateOfBirth
            // 
            this.dTPDateOfBirth.Location = new System.Drawing.Point(425, 320);
            this.dTPDateOfBirth.Name = "dTPDateOfBirth";
            this.dTPDateOfBirth.Size = new System.Drawing.Size(177, 23);
            this.dTPDateOfBirth.TabIndex = 48;
            // 
            // btnAddBorrowing
            // 
            this.btnAddBorrowing.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBorrowing.Location = new System.Drawing.Point(208, 400);
            this.btnAddBorrowing.Name = "btnAddBorrowing";
            this.btnAddBorrowing.Size = new System.Drawing.Size(173, 39);
            this.btnAddBorrowing.TabIndex = 49;
            this.btnAddBorrowing.Text = "Add Borrowing";
            this.btnAddBorrowing.UseVisualStyleBackColor = true;
            this.btnAddBorrowing.Visible = false;
            this.btnAddBorrowing.Click += new System.EventHandler(this.btnAddBorrowing_Click);
            // 
            // SearchClientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddBorrowing);
            this.Controls.Add(this.dTPDateOfBirth);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtSearchInsert);
            this.Controls.Add(this.comboxSearchOptions);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lblSearchAClient);
            this.Name = "SearchClientUserControl";
            this.Size = new System.Drawing.Size(662, 495);
            this.Load += new System.EventHandler(this.SerachClientUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtSearchInsert;
        private System.Windows.Forms.ComboBox comboxSearchOptions;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblSearchAClient;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dTPDateOfBirth;
        private System.Windows.Forms.Button btnAddBorrowing;
    }
}
