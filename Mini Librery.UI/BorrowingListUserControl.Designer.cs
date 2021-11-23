
namespace Mini_Librery.UI
{
    partial class BorrowingListUserControl
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
            this.dGVBorrowingList = new System.Windows.Forms.DataGridView();
            this.lblBorrowingList = new System.Windows.Forms.Label();
            this.btnBooksThatDidntReturnedIn6Month = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBorrowingList)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVBorrowingList
            // 
            this.dGVBorrowingList.AllowUserToAddRows = false;
            this.dGVBorrowingList.AllowUserToDeleteRows = false;
            this.dGVBorrowingList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBorrowingList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dGVBorrowingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBorrowingList.Location = new System.Drawing.Point(3, 102);
            this.dGVBorrowingList.Name = "dGVBorrowingList";
            this.dGVBorrowingList.ReadOnly = true;
            this.dGVBorrowingList.RowTemplate.Height = 25;
            this.dGVBorrowingList.Size = new System.Drawing.Size(682, 386);
            this.dGVBorrowingList.TabIndex = 3;
            // 
            // lblBorrowingList
            // 
            this.lblBorrowingList.AutoSize = true;
            this.lblBorrowingList.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBorrowingList.Location = new System.Drawing.Point(23, 28);
            this.lblBorrowingList.Name = "lblBorrowingList";
            this.lblBorrowingList.Size = new System.Drawing.Size(177, 32);
            this.lblBorrowingList.TabIndex = 2;
            this.lblBorrowingList.Text = "Borrowing List:";
            // 
            // btnBooksThatDidntReturnedIn6Month
            // 
            this.btnBooksThatDidntReturnedIn6Month.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBooksThatDidntReturnedIn6Month.Location = new System.Drawing.Point(438, 34);
            this.btnBooksThatDidntReturnedIn6Month.Name = "btnBooksThatDidntReturnedIn6Month";
            this.btnBooksThatDidntReturnedIn6Month.Size = new System.Drawing.Size(163, 39);
            this.btnBooksThatDidntReturnedIn6Month.TabIndex = 4;
            this.btnBooksThatDidntReturnedIn6Month.Text = "Show Books That Didnt Returned In 6 Month";
            this.btnBooksThatDidntReturnedIn6Month.UseVisualStyleBackColor = true;
            this.btnBooksThatDidntReturnedIn6Month.Click += new System.EventHandler(this.btnBooksThatDidntReturnedIn6Month_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(607, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 39);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BorrowingListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBooksThatDidntReturnedIn6Month);
            this.Controls.Add(this.dGVBorrowingList);
            this.Controls.Add(this.lblBorrowingList);
            this.Name = "BorrowingListUserControl";
            this.Size = new System.Drawing.Size(688, 491);
            this.Load += new System.EventHandler(this.BorrowingListUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBorrowingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVBorrowingList;
        private System.Windows.Forms.Label lblBorrowingList;
        private System.Windows.Forms.Button btnBooksThatDidntReturnedIn6Month;
        private System.Windows.Forms.Button btnRefresh;
    }
}
