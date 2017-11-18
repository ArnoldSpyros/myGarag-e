namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_SystemAdminMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ApplicationLOGO = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.AdminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MessagesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εισερχόμεναToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εξερχόμεναToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.πληροφορίεςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.επεξεργασίαΠροφίλToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StoreListPanel = new System.Windows.Forms.Panel();
            this.AdminTabPane = new System.Windows.Forms.TabControl();
            this.ShopsTabPage = new System.Windows.Forms.TabPage();
            this.CorporatesTabPage = new System.Windows.Forms.TabPage();
            this.AdminPanel.SuspendLayout();
            this.AdminMenuStrip.SuspendLayout();
            this.StoreListPanel.SuspendLayout();
            this.AdminTabPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationLOGO
            // 
            this.ApplicationLOGO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationLOGO.CausesValidation = false;
            this.ApplicationLOGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ApplicationLOGO.Location = new System.Drawing.Point(2, -1);
            this.ApplicationLOGO.MinimumSize = new System.Drawing.Size(780, 37);
            this.ApplicationLOGO.Name = "ApplicationLOGO";
            this.ApplicationLOGO.Size = new System.Drawing.Size(780, 37);
            this.ApplicationLOGO.TabIndex = 1;
            this.ApplicationLOGO.Text = "my Garag-e";
            this.ApplicationLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.AdminMenuStrip);
            this.AdminPanel.Location = new System.Drawing.Point(558, 39);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(224, 51);
            this.AdminPanel.TabIndex = 5;
            // 
            // AdminMenuStrip
            // 
            this.AdminMenuStrip.AutoSize = false;
            this.AdminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessagesMenuItem,
            this.AccountMenuItem});
            this.AdminMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AdminMenuStrip.Name = "AdminMenuStrip";
            this.AdminMenuStrip.Size = new System.Drawing.Size(224, 25);
            this.AdminMenuStrip.TabIndex = 0;
            this.AdminMenuStrip.Text = "menuStrip1";
            // 
            // MessagesMenuItem
            // 
            this.MessagesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.εισερχόμεναToolStripMenuItem,
            this.εξερχόμεναToolStripMenuItem});
            this.MessagesMenuItem.Name = "MessagesMenuItem";
            this.MessagesMenuItem.Size = new System.Drawing.Size(77, 21);
            this.MessagesMenuItem.Text = "Μηνύματα";
            // 
            // εισερχόμεναToolStripMenuItem
            // 
            this.εισερχόμεναToolStripMenuItem.Name = "εισερχόμεναToolStripMenuItem";
            this.εισερχόμεναToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.εισερχόμεναToolStripMenuItem.Text = "Εισερχόμενα";
            // 
            // εξερχόμεναToolStripMenuItem
            // 
            this.εξερχόμεναToolStripMenuItem.Name = "εξερχόμεναToolStripMenuItem";
            this.εξερχόμεναToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.εξερχόμεναToolStripMenuItem.Text = "Εξερχόμενα";
            // 
            // AccountMenuItem
            // 
            this.AccountMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.πληροφορίεςToolStripMenuItem,
            this.επεξεργασίαΠροφίλToolStripMenuItem});
            this.AccountMenuItem.Name = "AccountMenuItem";
            this.AccountMenuItem.Size = new System.Drawing.Size(125, 21);
            this.AccountMenuItem.Text = "Ο λογαριασμός μου";
            // 
            // πληροφορίεςToolStripMenuItem
            // 
            this.πληροφορίεςToolStripMenuItem.Name = "πληροφορίεςToolStripMenuItem";
            this.πληροφορίεςToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.πληροφορίεςToolStripMenuItem.Text = "Πληροφορίες Προφίλ";
            // 
            // επεξεργασίαΠροφίλToolStripMenuItem
            // 
            this.επεξεργασίαΠροφίλToolStripMenuItem.Name = "επεξεργασίαΠροφίλToolStripMenuItem";
            this.επεξεργασίαΠροφίλToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.επεξεργασίαΠροφίλToolStripMenuItem.Text = "Επεξεργασία προφίλ";
            // 
            // StoreListPanel
            // 
            this.StoreListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreListPanel.Controls.Add(this.AdminTabPane);
            this.StoreListPanel.Location = new System.Drawing.Point(2, 109);
            this.StoreListPanel.Name = "StoreListPanel";
            this.StoreListPanel.Size = new System.Drawing.Size(780, 450);
            this.StoreListPanel.TabIndex = 6;
            // 
            // AdminTabPane
            // 
            this.AdminTabPane.Controls.Add(this.ShopsTabPage);
            this.AdminTabPane.Controls.Add(this.CorporatesTabPage);
            this.AdminTabPane.Location = new System.Drawing.Point(11, 4);
            this.AdminTabPane.Name = "AdminTabPane";
            this.AdminTabPane.SelectedIndex = 0;
            this.AdminTabPane.Size = new System.Drawing.Size(769, 443);
            this.AdminTabPane.TabIndex = 0;
            // 
            // ShopsTabPage
            // 
            this.ShopsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ShopsTabPage.Name = "ShopsTabPage";
            this.ShopsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShopsTabPage.Size = new System.Drawing.Size(761, 417);
            this.ShopsTabPage.TabIndex = 0;
            this.ShopsTabPage.Text = "Καταστήματα";
            this.ShopsTabPage.UseVisualStyleBackColor = true;
            // 
            // CorporatesTabPage
            // 
            this.CorporatesTabPage.Location = new System.Drawing.Point(4, 22);
            this.CorporatesTabPage.Name = "CorporatesTabPage";
            this.CorporatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CorporatesTabPage.Size = new System.Drawing.Size(761, 417);
            this.CorporatesTabPage.TabIndex = 1;
            this.CorporatesTabPage.Text = "Συνεργάτες";
            this.CorporatesTabPage.UseVisualStyleBackColor = true;
            // 
            // myGarage_SystemAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.StoreListPanel);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.ApplicationLOGO);
            this.MinimumSize = new System.Drawing.Size(780, 600);
            this.Name = "myGarage_SystemAdminMain";
            this.Text = "myGarage_SystemAdminMain";
            this.AdminPanel.ResumeLayout(false);
            this.AdminMenuStrip.ResumeLayout(false);
            this.AdminMenuStrip.PerformLayout();
            this.StoreListPanel.ResumeLayout(false);
            this.AdminTabPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ApplicationLOGO;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.MenuStrip AdminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MessagesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εισερχόμεναToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εξερχόμεναToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem πληροφορίεςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem επεξεργασίαΠροφίλToolStripMenuItem;
        private System.Windows.Forms.Panel StoreListPanel;
        private System.Windows.Forms.TabControl AdminTabPane;
        private System.Windows.Forms.TabPage ShopsTabPage;
        private System.Windows.Forms.TabPage CorporatesTabPage;
    }
}