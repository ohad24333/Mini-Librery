
namespace Mini_Librery.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serachForABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBooksListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serachForAClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serachForABoroowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBorrowingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLowStripMassege = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.borrowingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.serachForABookToolStripMenuItem,
            this.showBooksListToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // serachForABookToolStripMenuItem
            // 
            this.serachForABookToolStripMenuItem.Name = "serachForABookToolStripMenuItem";
            this.serachForABookToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.serachForABookToolStripMenuItem.Text = "Serach For A Book";
            this.serachForABookToolStripMenuItem.Click += new System.EventHandler(this.serachForABookToolStripMenuItem_Click);
            // 
            // showBooksListToolStripMenuItem
            // 
            this.showBooksListToolStripMenuItem.Name = "showBooksListToolStripMenuItem";
            this.showBooksListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showBooksListToolStripMenuItem.Text = "Show Books List";
            this.showBooksListToolStripMenuItem.Click += new System.EventHandler(this.showBooksListToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClientToolStripMenuItem,
            this.serachForAClientToolStripMenuItem,
            this.showClientsListToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // serachForAClientToolStripMenuItem
            // 
            this.serachForAClientToolStripMenuItem.Name = "serachForAClientToolStripMenuItem";
            this.serachForAClientToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.serachForAClientToolStripMenuItem.Text = "Serach For A Client";
            this.serachForAClientToolStripMenuItem.Click += new System.EventHandler(this.serachForAClientToolStripMenuItem_Click);
            // 
            // showClientsListToolStripMenuItem
            // 
            this.showClientsListToolStripMenuItem.Name = "showClientsListToolStripMenuItem";
            this.showClientsListToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.showClientsListToolStripMenuItem.Text = "Show Clients List";
            this.showClientsListToolStripMenuItem.Click += new System.EventHandler(this.showClientsListToolStripMenuItem_Click);
            // 
            // borrowingToolStripMenuItem
            // 
            this.borrowingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serachForABoroowToolStripMenuItem,
            this.showBorrowingListToolStripMenuItem});
            this.borrowingToolStripMenuItem.Name = "borrowingToolStripMenuItem";
            this.borrowingToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.borrowingToolStripMenuItem.Text = "Borrowing";
            // 
            // serachForABoroowToolStripMenuItem
            // 
            this.serachForABoroowToolStripMenuItem.Name = "serachForABoroowToolStripMenuItem";
            this.serachForABoroowToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.serachForABoroowToolStripMenuItem.Text = "Serach For A Boroow";
            this.serachForABoroowToolStripMenuItem.Click += new System.EventHandler(this.serachForABoroowToolStripMenuItem_Click);
            // 
            // showBorrowingListToolStripMenuItem
            // 
            this.showBorrowingListToolStripMenuItem.Name = "showBorrowingListToolStripMenuItem";
            this.showBorrowingListToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showBorrowingListToolStripMenuItem.Text = "Show Borrowing List";
            this.showBorrowingListToolStripMenuItem.Click += new System.EventHandler(this.showBorrowingListToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 464);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLowStripMassege});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblLowStripMassege
            // 
            this.lblLowStripMassege.Name = "lblLowStripMassege";
            this.lblLowStripMassege.Size = new System.Drawing.Size(16, 17);
            this.lblLowStripMassege.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serachForABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBooksListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serachForAClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serachForABoroowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBorrowingListToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLowStripMassege;
    }
}

