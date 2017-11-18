namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_ConsumerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myGarage_ConsumerMain));
            this.ApplicationLOGO = new System.Windows.Forms.Label();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.ConsumerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AppointmentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εισερχόμεναToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εξερχόμεναToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.πληροφορίεςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.επεξεργασίαΠροφίλToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.PartsShopPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IconColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.BuyItemColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UserPanel.SuspendLayout();
            this.ConsumerMenuStrip.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.PartsShopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationLOGO
            // 
            this.ApplicationLOGO.CausesValidation = false;
            resources.ApplyResources(this.ApplicationLOGO, "ApplicationLOGO");
            this.ApplicationLOGO.Name = "ApplicationLOGO";
            // 
            // UserPanel
            // 
            resources.ApplyResources(this.UserPanel, "UserPanel");
            this.UserPanel.Controls.Add(this.ConsumerMenuStrip);
            this.UserPanel.Name = "UserPanel";
            // 
            // ConsumerMenuStrip
            // 
            resources.ApplyResources(this.ConsumerMenuStrip, "ConsumerMenuStrip");
            this.ConsumerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppointmentsMenuItem,
            this.CartMenuItem,
            this.MessagesMenuItem,
            this.AccountMenuItem});
            this.ConsumerMenuStrip.Name = "ConsumerMenuStrip";
            // 
            // AppointmentsMenuItem
            // 
            this.AppointmentsMenuItem.Name = "AppointmentsMenuItem";
            resources.ApplyResources(this.AppointmentsMenuItem, "AppointmentsMenuItem");
            // 
            // CartMenuItem
            // 
            this.CartMenuItem.Name = "CartMenuItem";
            resources.ApplyResources(this.CartMenuItem, "CartMenuItem");
            // 
            // MessagesMenuItem
            // 
            this.MessagesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.εισερχόμεναToolStripMenuItem,
            this.εξερχόμεναToolStripMenuItem});
            this.MessagesMenuItem.Name = "MessagesMenuItem";
            resources.ApplyResources(this.MessagesMenuItem, "MessagesMenuItem");
            // 
            // εισερχόμεναToolStripMenuItem
            // 
            this.εισερχόμεναToolStripMenuItem.Name = "εισερχόμεναToolStripMenuItem";
            resources.ApplyResources(this.εισερχόμεναToolStripMenuItem, "εισερχόμεναToolStripMenuItem");
            // 
            // εξερχόμεναToolStripMenuItem
            // 
            this.εξερχόμεναToolStripMenuItem.Name = "εξερχόμεναToolStripMenuItem";
            resources.ApplyResources(this.εξερχόμεναToolStripMenuItem, "εξερχόμεναToolStripMenuItem");
            // 
            // AccountMenuItem
            // 
            this.AccountMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.πληροφορίεςToolStripMenuItem,
            this.επεξεργασίαΠροφίλToolStripMenuItem});
            this.AccountMenuItem.Name = "AccountMenuItem";
            resources.ApplyResources(this.AccountMenuItem, "AccountMenuItem");
            // 
            // πληροφορίεςToolStripMenuItem
            // 
            this.πληροφορίεςToolStripMenuItem.Name = "πληροφορίεςToolStripMenuItem";
            resources.ApplyResources(this.πληροφορίεςToolStripMenuItem, "πληροφορίεςToolStripMenuItem");
            // 
            // επεξεργασίαΠροφίλToolStripMenuItem
            // 
            this.επεξεργασίαΠροφίλToolStripMenuItem.Name = "επεξεργασίαΠροφίλToolStripMenuItem";
            resources.ApplyResources(this.επεξεργασίαΠροφίλToolStripMenuItem, "επεξεργασίαΠροφίλToolStripMenuItem");
            // 
            // SearchPanel
            // 
            resources.ApplyResources(this.SearchPanel, "SearchPanel");
            this.SearchPanel.Controls.Add(this.SearchBtn);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Name = "SearchPanel";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::myGarag_e_MAINPROJECT.Properties.Resources.magnifier_1093184_960_720;
            resources.ApplyResources(this.SearchBtn, "SearchBtn");
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            resources.ApplyResources(this.SearchTextBox, "SearchTextBox");
            this.SearchTextBox.Name = "SearchTextBox";
            // 
            // PartsShopPanel
            // 
            resources.ApplyResources(this.PartsShopPanel, "PartsShopPanel");
            this.PartsShopPanel.Controls.Add(this.dataGridView1);
            this.PartsShopPanel.Name = "PartsShopPanel";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconColumn,
            this.BuyItemColumn});
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // IconColumn
            // 
            resources.ApplyResources(this.IconColumn, "IconColumn");
            this.IconColumn.Name = "IconColumn";
            this.IconColumn.ReadOnly = true;
            this.IconColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BuyItemColumn
            // 
            resources.ApplyResources(this.BuyItemColumn, "BuyItemColumn");
            this.BuyItemColumn.Name = "BuyItemColumn";
            this.BuyItemColumn.ReadOnly = true;
            this.BuyItemColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BuyItemColumn.Text = "Αγορά";
            this.BuyItemColumn.UseColumnTextForButtonValue = true;
            // 
            // myGarage_ConsumerMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PartsShopPanel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.ApplicationLOGO);
            this.Name = "myGarage_ConsumerMain";
            this.UserPanel.ResumeLayout(false);
            this.ConsumerMenuStrip.ResumeLayout(false);
            this.ConsumerMenuStrip.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.PartsShopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ApplicationLOGO;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.MenuStrip ConsumerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem πληροφορίεςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem επεξεργασίαΠροφίλToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MessagesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εισερχόμεναToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εξερχόμεναToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CartMenuItem;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ToolStripMenuItem AppointmentsMenuItem;
        private System.Windows.Forms.Panel PartsShopPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn IconColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BuyItemColumn;
    }
}

