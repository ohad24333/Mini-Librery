
namespace Mini_Librery.UI
{
    partial class SearchBookUserControl
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
            this.lblSearchABook = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.comboxSearchOptions = new System.Windows.Forms.ComboBox();
            this.txtSearchInsert = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dTPDatePublished = new System.Windows.Forms.DateTimePicker();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtNumberOfCopies = new System.Windows.Forms.TextBox();
            this.txtNumberOfPages = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblNumberOfCopies = new System.Windows.Forms.Label();
            this.lblNamberOfPages = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSearchABook
            // 
            this.lblSearchABook.AutoSize = true;
            this.lblSearchABook.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchABook.Location = new System.Drawing.Point(41, 45);
            this.lblSearchABook.Name = "lblSearchABook";
            this.lblSearchABook.Size = new System.Drawing.Size(201, 37);
            this.lblSearchABook.TabIndex = 0;
            this.lblSearchABook.Text = "Search A Book:";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBy.Location = new System.Drawing.Point(35, 119);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(28, 21);
            this.lblBy.TabIndex = 1;
            this.lblBy.Text = "By";
            // 
            // comboxSearchOptions
            // 
            this.comboxSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSearchOptions.FormattingEnabled = true;
            this.comboxSearchOptions.Location = new System.Drawing.Point(93, 119);
            this.comboxSearchOptions.Name = "comboxSearchOptions";
            this.comboxSearchOptions.Size = new System.Drawing.Size(136, 23);
            this.comboxSearchOptions.TabIndex = 2;
            // 
            // txtSearchInsert
            // 
            this.txtSearchInsert.Location = new System.Drawing.Point(94, 183);
            this.txtSearchInsert.Name = "txtSearchInsert";
            this.txtSearchInsert.Size = new System.Drawing.Size(135, 23);
            this.txtSearchInsert.TabIndex = 3;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnter.Location = new System.Drawing.Point(35, 185);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(53, 21);
            this.lblEnter.TabIndex = 4;
            this.lblEnter.Text = "Enter:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(139, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(332, 343);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 23);
            this.txtID.TabIndex = 26;
            this.txtID.Visible = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChanges.Location = new System.Drawing.Point(475, 416);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(133, 39);
            this.btnSaveChanges.TabIndex = 25;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(41, 416);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 39);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // dTPDatePublished
            // 
            this.dTPDatePublished.Enabled = false;
            this.dTPDatePublished.Location = new System.Drawing.Point(443, 281);
            this.dTPDatePublished.Name = "dTPDatePublished";
            this.dTPDatePublished.Size = new System.Drawing.Size(165, 23);
            this.dTPDatePublished.TabIndex = 22;
            this.dTPDatePublished.Visible = false;
            // 
            // txtBookName
            // 
            this.txtBookName.Enabled = false;
            this.txtBookName.Location = new System.Drawing.Point(388, 99);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(220, 23);
            this.txtBookName.TabIndex = 21;
            this.txtBookName.Visible = false;
            // 
            // txtNumberOfCopies
            // 
            this.txtNumberOfCopies.Enabled = false;
            this.txtNumberOfCopies.Location = new System.Drawing.Point(472, 218);
            this.txtNumberOfCopies.Name = "txtNumberOfCopies";
            this.txtNumberOfCopies.Size = new System.Drawing.Size(136, 23);
            this.txtNumberOfCopies.TabIndex = 20;
            this.txtNumberOfCopies.Visible = false;
            // 
            // txtNumberOfPages
            // 
            this.txtNumberOfPages.Enabled = false;
            this.txtNumberOfPages.Location = new System.Drawing.Point(472, 156);
            this.txtNumberOfPages.Name = "txtNumberOfPages";
            this.txtNumberOfPages.Size = new System.Drawing.Size(136, 23);
            this.txtNumberOfPages.TabIndex = 19;
            this.txtNumberOfPages.Visible = false;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(388, 48);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(220, 23);
            this.txtAuthor.TabIndex = 18;
            this.txtAuthor.Visible = false;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatePublished.Location = new System.Drawing.Point(279, 281);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(146, 25);
            this.lblDatePublished.TabIndex = 12;
            this.lblDatePublished.Text = "Date Published:";
            this.lblDatePublished.Visible = false;
            // 
            // lblNumberOfCopies
            // 
            this.lblNumberOfCopies.AutoSize = true;
            this.lblNumberOfCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfCopies.Location = new System.Drawing.Point(279, 218);
            this.lblNumberOfCopies.Name = "lblNumberOfCopies";
            this.lblNumberOfCopies.Size = new System.Drawing.Size(176, 25);
            this.lblNumberOfCopies.TabIndex = 13;
            this.lblNumberOfCopies.Text = "Number Of Copies:";
            this.lblNumberOfCopies.Visible = false;
            // 
            // lblNamberOfPages
            // 
            this.lblNamberOfPages.AutoSize = true;
            this.lblNamberOfPages.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamberOfPages.Location = new System.Drawing.Point(279, 154);
            this.lblNamberOfPages.Name = "lblNamberOfPages";
            this.lblNamberOfPages.Size = new System.Drawing.Size(167, 25);
            this.lblNamberOfPages.TabIndex = 14;
            this.lblNamberOfPages.Text = "Namber Of Pages:";
            this.lblNamberOfPages.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(279, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 25);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name:";
            this.lblName.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(279, 342);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 25);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(279, 47);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(78, 25);
            this.lblAuthor.TabIndex = 17;
            this.lblAuthor.Text = "Author:";
            this.lblAuthor.Visible = false;
            // 
            // SearchUserControl
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dTPDatePublished);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtNumberOfCopies);
            this.Controls.Add(this.txtNumberOfPages);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblNumberOfCopies);
            this.Controls.Add(this.lblNamberOfPages);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtSearchInsert);
            this.Controls.Add(this.comboxSearchOptions);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lblSearchABook);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(696, 564);
            this.Load += new System.EventHandler(this.SearchUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchABook;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.ComboBox comboxSearchOptions;
        private System.Windows.Forms.TextBox txtSearchInsert;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dTPDatePublished;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtNumberOfCopies;
        private System.Windows.Forms.TextBox txtNumberOfPages;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblNumberOfCopies;
        private System.Windows.Forms.Label lblNamberOfPages;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAuthor;
    }
}
