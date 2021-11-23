
namespace Mini_Librery.UI
{
    partial class ClientListUserControl
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
            this.dGVClientList = new System.Windows.Forms.DataGridView();
            this.lblClientsList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVClientList
            // 
            this.dGVClientList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVClientList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dGVClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClientList.Location = new System.Drawing.Point(3, 87);
            this.dGVClientList.Name = "dGVClientList";
            this.dGVClientList.RowTemplate.Height = 25;
            this.dGVClientList.Size = new System.Drawing.Size(686, 354);
            this.dGVClientList.TabIndex = 3;
            // 
            // lblClientsList
            // 
            this.lblClientsList.AutoSize = true;
            this.lblClientsList.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientsList.Location = new System.Drawing.Point(6, 20);
            this.lblClientsList.Name = "lblClientsList";
            this.lblClientsList.Size = new System.Drawing.Size(131, 32);
            this.lblClientsList.TabIndex = 2;
            this.lblClientsList.Text = "Clients List";
            // 
            // ClientListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGVClientList);
            this.Controls.Add(this.lblClientsList);
            this.Name = "ClientListUserControl";
            this.Size = new System.Drawing.Size(692, 444);
            this.Load += new System.EventHandler(this.ClientListUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVClientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVClientList;
        private System.Windows.Forms.Label lblClientsList;
    }
}
