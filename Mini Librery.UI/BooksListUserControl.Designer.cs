
namespace Mini_Librery.UI
{
    partial class BooksListUserControl
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
            this.lblBooksList = new System.Windows.Forms.Label();
            this.dGVBookList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBooksList
            // 
            this.lblBooksList.AutoSize = true;
            this.lblBooksList.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBooksList.Location = new System.Drawing.Point(12, 24);
            this.lblBooksList.Name = "lblBooksList";
            this.lblBooksList.Size = new System.Drawing.Size(130, 32);
            this.lblBooksList.TabIndex = 0;
            this.lblBooksList.Text = "Books List:";
            // 
            // dGVBookList
            // 
            this.dGVBookList.AllowUserToAddRows = false;
            this.dGVBookList.AllowUserToDeleteRows = false;
            this.dGVBookList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBookList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dGVBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBookList.Location = new System.Drawing.Point(3, 86);
            this.dGVBookList.Name = "dGVBookList";
            this.dGVBookList.ReadOnly = true;
            this.dGVBookList.RowTemplate.Height = 25;
            this.dGVBookList.Size = new System.Drawing.Size(615, 330);
            this.dGVBookList.TabIndex = 1;
            // 
            // BooksListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGVBookList);
            this.Controls.Add(this.lblBooksList);
            this.Name = "BooksListUserControl";
            this.Size = new System.Drawing.Size(621, 419);
            this.Load += new System.EventHandler(this.BooksListUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooksList;
        private System.Windows.Forms.DataGridView dGVBookList;
    }
}
