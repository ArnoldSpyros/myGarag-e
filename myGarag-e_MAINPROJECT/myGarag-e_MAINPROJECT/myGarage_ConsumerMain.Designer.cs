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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ConsumerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AppointmentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newappointmentMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listappointmentMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMsgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationLOGO = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.PartsShopPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.ConsumerMenuStrip.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.PartsShopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.ConsumerMenuStrip);
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
            this.ConsumerMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ConsumerMenuStrip_ItemClicked);
            // 
            // AppointmentsMenuItem
            // 
            this.AppointmentsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newappointmentMenuStripItem,
            this.listappointmentMenuStripItem});
            this.AppointmentsMenuItem.Name = "AppointmentsMenuItem";
            resources.ApplyResources(this.AppointmentsMenuItem, "AppointmentsMenuItem");
            // 
            // newappointmentMenuStripItem
            // 
            this.newappointmentMenuStripItem.Name = "newappointmentMenuStripItem";
            resources.ApplyResources(this.newappointmentMenuStripItem, "newappointmentMenuStripItem");
            this.newappointmentMenuStripItem.Click += new System.EventHandler(this.newappointmentMenuStripItem_Click);
            // 
            // listappointmentMenuStripItem
            // 
            this.listappointmentMenuStripItem.Name = "listappointmentMenuStripItem";
            resources.ApplyResources(this.listappointmentMenuStripItem, "listappointmentMenuStripItem");
            this.listappointmentMenuStripItem.Click += new System.EventHandler(this.listappointmentMenuStripItem_Click);
            // 
            // CartMenuItem
            // 
            this.CartMenuItem.Name = "CartMenuItem";
            resources.ApplyResources(this.CartMenuItem, "CartMenuItem");
            // 
            // MessagesMenuItem
            // 
            this.MessagesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InboxToolStripMenuItem,
            this.NewMsgToolStripMenuItem});
            this.MessagesMenuItem.Name = "MessagesMenuItem";
            resources.ApplyResources(this.MessagesMenuItem, "MessagesMenuItem");
            // 
            // InboxToolStripMenuItem
            // 
            this.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem";
            resources.ApplyResources(this.InboxToolStripMenuItem, "InboxToolStripMenuItem");
            this.InboxToolStripMenuItem.Click += new System.EventHandler(this.InboxToolStripMenuItem_Click);
            // 
            // NewMsgToolStripMenuItem
            // 
            this.NewMsgToolStripMenuItem.Name = "NewMsgToolStripMenuItem";
            resources.ApplyResources(this.NewMsgToolStripMenuItem, "NewMsgToolStripMenuItem");
            this.NewMsgToolStripMenuItem.Click += new System.EventHandler(this.NewMsgToolStripMenuItem_Click);
            // 
            // AccountMenuItem
            // 
            this.AccountMenuItem.Name = "AccountMenuItem";
            resources.ApplyResources(this.AccountMenuItem, "AccountMenuItem");
            this.AccountMenuItem.Click += new System.EventHandler(this.AccountMenuItem_Click);
            // 
            // ApplicationLOGO
            // 
            this.ApplicationLOGO.CausesValidation = false;
            resources.ApplyResources(this.ApplicationLOGO, "ApplicationLOGO");
            this.ApplicationLOGO.Name = "ApplicationLOGO";
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
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
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
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // myGarage_ConsumerMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PartsShopPanel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.ApplicationLOGO);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "myGarage_ConsumerMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.myGarage_ConsumerMain_FormClosing);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip ConsumerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MessagesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CartMenuItem;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ToolStripMenuItem AppointmentsMenuItem;
        private System.Windows.Forms.Panel PartsShopPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem newappointmentMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem listappointmentMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem NewMsgToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

