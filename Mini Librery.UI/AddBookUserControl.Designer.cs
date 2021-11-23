
namespace Mini_Librery.UI
{
    partial class AddBookUserControl
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
            this.lblAddNewBook = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNamberOfPages = new System.Windows.Forms.Label();
            this.lblNumberOfCopies = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtNumberOfPages = new System.Windows.Forms.TextBox();
            this.txtNumberOfCopies = new System.Windows.Forms.TextBox();
            this.dTPDatePublished = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddNewBook
            // 
            this.lblAddNewBook.AutoSize = true;
            this.lblAddNewBook.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewBook.Location = new System.Drawing.Point(40, 38);
            this.lblAddNewBook.Name = "lblAddNewBook";
            this.lblAddNewBook.Size = new System.Drawing.Size(184, 32);
            this.lblAddNewBook.TabIndex = 0;
            this.lblAddNewBook.Text = "Add New Book:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(40, 107);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(78, 25);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(40, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblNamberOfPages
            // 
            this.lblNamberOfPages.AutoSize = true;
            this.lblNamberOfPages.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamberOfPages.Location = new System.Drawing.Point(40, 214);
            this.lblNamberOfPages.Name = "lblNamberOfPages";
            this.lblNamberOfPages.Size = new System.Drawing.Size(167, 25);
            this.lblNamberOfPages.TabIndex = 1;
            this.lblNamberOfPages.Text = "Namber Of Pages:";
            // 
            // lblNumberOfCopies
            // 
            this.lblNumberOfCopies.AutoSize = true;
            this.lblNumberOfCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfCopies.Location = new System.Drawing.Point(40, 278);
            this.lblNumberOfCopies.Name = "lblNumberOfCopies";
            this.lblNumberOfCopies.Size = new System.Drawing.Size(176, 25);
            this.lblNumberOfCopies.TabIndex = 1;
            this.lblNumberOfCopies.Text = "Number Of Copies:";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatePublished.Location = new System.Drawing.Point(40, 341);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(146, 25);
            this.lblDatePublished.TabIndex = 1;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(149, 108);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(220, 23);
            this.txtAuthor.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(149, 164);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(220, 23);
            this.txtBookName.TabIndex = 3;
            // 
            // txtNumberOfPages
            // 
            this.txtNumberOfPages.Location = new System.Drawing.Point(233, 219);
            this.txtNumberOfPages.Name = "txtNumberOfPages";
            this.txtNumberOfPages.Size = new System.Drawing.Size(136, 23);
            this.txtNumberOfPages.TabIndex = 5;
            // 
            // txtNumberOfCopies
            // 
            this.txtNumberOfCopies.Location = new System.Drawing.Point(233, 278);
            this.txtNumberOfCopies.Name = "txtNumberOfCopies";
            this.txtNumberOfCopies.Size = new System.Drawing.Size(136, 23);
            this.txtNumberOfCopies.TabIndex = 6;
            // 
            // dTPDatePublished
            // 
            this.dTPDatePublished.Location = new System.Drawing.Point(204, 341);
            this.dTPDatePublished.Name = "dTPDatePublished";
            this.dTPDatePublished.Size = new System.Drawing.Size(165, 23);
            this.dTPDatePublished.TabIndex = 7;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewBook.Location = new System.Drawing.Point(413, 343);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(133, 39);
            this.btnAddNewBook.TabIndex = 8;
            this.btnAddNewBook.Text = "Add";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(465, 103);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(575, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 39);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChanges.Location = new System.Drawing.Point(575, 159);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(133, 39);
            this.btnSaveChanges.TabIndex = 10;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(518, 104);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 23);
            this.txtID.TabIndex = 11;
            // 
            // AddClientUserControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.dTPDatePublished);
            this.Controls.Add(this.txtNumberOfCopies);
            this.Controls.Add(this.txtNumberOfPages);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblNumberOfCopies);
            this.Controls.Add(this.lblNamberOfPages);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblAddNewBook);
            this.Name = "AddClientUserControll";
            this.Size = new System.Drawing.Size(746, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewBook;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNamberOfPages;
        private System.Windows.Forms.Label lblNumberOfCopies;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtNumberOfPages;
        private System.Windows.Forms.TextBox txtNumberOfCopies;
        private System.Windows.Forms.DateTimePicker dTPDatePublished;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtID;
    }
}
