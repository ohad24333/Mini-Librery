
namespace Mini_Librery.UI
{
    partial class BorrowingUserControl
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
            this.lblBorrowingFor = new System.Windows.Forms.Label();
            this.lblNameOfClient = new System.Windows.Forms.Label();
            this.dGVBookStiilWithClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewBookToBorowingList = new System.Windows.Forms.Button();
            this.lblAddNewBookToBorowingList = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxBookName = new System.Windows.Forms.ComboBox();
            this.lblSetTheStartBorrowingDate = new System.Windows.Forms.Label();
            this.dTPStartOfBorrowing = new System.Windows.Forms.DateTimePicker();
            this.lblReturningDate = new System.Windows.Forms.Label();
            this.lblReturningDateValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBookStiilWithClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBorrowingFor
            // 
            this.lblBorrowingFor.AutoSize = true;
            this.lblBorrowingFor.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBorrowingFor.Location = new System.Drawing.Point(35, 41);
            this.lblBorrowingFor.Name = "lblBorrowingFor";
            this.lblBorrowingFor.Size = new System.Drawing.Size(176, 32);
            this.lblBorrowingFor.TabIndex = 0;
            this.lblBorrowingFor.Text = "Borrowing For:";
            // 
            // lblNameOfClient
            // 
            this.lblNameOfClient.AutoSize = true;
            this.lblNameOfClient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameOfClient.Location = new System.Drawing.Point(247, 41);
            this.lblNameOfClient.Name = "lblNameOfClient";
            this.lblNameOfClient.Size = new System.Drawing.Size(0, 32);
            this.lblNameOfClient.TabIndex = 1;
            // 
            // dGVBookStiilWithClient
            // 
            this.dGVBookStiilWithClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBookStiilWithClient.Location = new System.Drawing.Point(35, 150);
            this.dGVBookStiilWithClient.Name = "dGVBookStiilWithClient";
            this.dGVBookStiilWithClient.RowTemplate.Height = 25;
            this.dGVBookStiilWithClient.Size = new System.Drawing.Size(257, 273);
            this.dGVBookStiilWithClient.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Books That Still With This Client";
            // 
            // btnAddNewBookToBorowingList
            // 
            this.btnAddNewBookToBorowingList.Location = new System.Drawing.Point(568, 388);
            this.btnAddNewBookToBorowingList.Name = "btnAddNewBookToBorowingList";
            this.btnAddNewBookToBorowingList.Size = new System.Drawing.Size(102, 35);
            this.btnAddNewBookToBorowingList.TabIndex = 4;
            this.btnAddNewBookToBorowingList.Text = "Add";
            this.btnAddNewBookToBorowingList.UseVisualStyleBackColor = true;
            this.btnAddNewBookToBorowingList.Click += new System.EventHandler(this.btnAddNewBookToBorowingList_Click);
            // 
            // lblAddNewBookToBorowingList
            // 
            this.lblAddNewBookToBorowingList.AutoSize = true;
            this.lblAddNewBookToBorowingList.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAddNewBookToBorowingList.Location = new System.Drawing.Point(382, 105);
            this.lblAddNewBookToBorowingList.Name = "lblAddNewBookToBorowingList";
            this.lblAddNewBookToBorowingList.Size = new System.Drawing.Size(288, 25);
            this.lblAddNewBookToBorowingList.TabIndex = 5;
            this.lblAddNewBookToBorowingList.Text = "Add New Book To Borowing List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(382, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Which Book You Want To Brrow?";
            // 
            // comboxBookName
            // 
            this.comboxBookName.FormattingEnabled = true;
            this.comboxBookName.Location = new System.Drawing.Point(382, 190);
            this.comboxBookName.Name = "comboxBookName";
            this.comboxBookName.Size = new System.Drawing.Size(224, 23);
            this.comboxBookName.TabIndex = 7;
            // 
            // lblSetTheStartBorrowingDate
            // 
            this.lblSetTheStartBorrowingDate.AutoSize = true;
            this.lblSetTheStartBorrowingDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetTheStartBorrowingDate.Location = new System.Drawing.Point(382, 238);
            this.lblSetTheStartBorrowingDate.Name = "lblSetTheStartBorrowingDate";
            this.lblSetTheStartBorrowingDate.Size = new System.Drawing.Size(202, 20);
            this.lblSetTheStartBorrowingDate.TabIndex = 8;
            this.lblSetTheStartBorrowingDate.Text = "Set The Start Borrowing Date";
            // 
            // dTPStartOfBorrowing
            // 
            this.dTPStartOfBorrowing.Location = new System.Drawing.Point(382, 273);
            this.dTPStartOfBorrowing.Name = "dTPStartOfBorrowing";
            this.dTPStartOfBorrowing.Size = new System.Drawing.Size(224, 23);
            this.dTPStartOfBorrowing.TabIndex = 9;
            this.dTPStartOfBorrowing.Value = new System.DateTime(2021, 11, 13, 0, 0, 0, 0);
            this.dTPStartOfBorrowing.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblReturningDate
            // 
            this.lblReturningDate.AutoSize = true;
            this.lblReturningDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReturningDate.Location = new System.Drawing.Point(382, 316);
            this.lblReturningDate.Name = "lblReturningDate";
            this.lblReturningDate.Size = new System.Drawing.Size(109, 20);
            this.lblReturningDate.TabIndex = 10;
            this.lblReturningDate.Text = "Returning Date";
            // 
            // lblReturningDateValue
            // 
            this.lblReturningDateValue.AutoSize = true;
            this.lblReturningDateValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReturningDateValue.ForeColor = System.Drawing.Color.Red;
            this.lblReturningDateValue.Location = new System.Drawing.Point(382, 352);
            this.lblReturningDateValue.Name = "lblReturningDateValue";
            this.lblReturningDateValue.Size = new System.Drawing.Size(0, 20);
            this.lblReturningDateValue.TabIndex = 11;
            // 
            // BorrowingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblReturningDateValue);
            this.Controls.Add(this.lblReturningDate);
            this.Controls.Add(this.dTPStartOfBorrowing);
            this.Controls.Add(this.lblSetTheStartBorrowingDate);
            this.Controls.Add(this.comboxBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAddNewBookToBorowingList);
            this.Controls.Add(this.btnAddNewBookToBorowingList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVBookStiilWithClient);
            this.Controls.Add(this.lblNameOfClient);
            this.Controls.Add(this.lblBorrowingFor);
            this.Name = "BorrowingUserControl";
            this.Size = new System.Drawing.Size(749, 489);
            this.Load += new System.EventHandler(this.BorrowingUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBookStiilWithClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorrowingFor;
        private System.Windows.Forms.Label lblNameOfClient;
        private System.Windows.Forms.DataGridView dGVBookStiilWithClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewBookToBorowingList;
        private System.Windows.Forms.Label lblAddNewBookToBorowingList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxBookName;
        private System.Windows.Forms.Label lblSetTheStartBorrowingDate;
        private System.Windows.Forms.DateTimePicker dTPStartOfBorrowing;
        private System.Windows.Forms.Label lblReturningDate;
        private System.Windows.Forms.Label lblReturningDateValue;
    }
}
