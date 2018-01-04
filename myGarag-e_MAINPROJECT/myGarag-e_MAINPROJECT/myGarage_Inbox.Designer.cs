namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_Inbox
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Εισερχόμενα");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Απεσταλμένα");
            this.inboxDGV = new System.Windows.Forms.DataGridView();
            this.messageCategoryL = new System.Windows.Forms.Label();
            this.deleteMessageB = new System.Windows.Forms.Button();
            this.answerMessageB = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.inboxDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // inboxDGV
            // 
            this.inboxDGV.AllowUserToAddRows = false;
            this.inboxDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inboxDGV.Location = new System.Drawing.Point(156, 95);
            this.inboxDGV.Name = "inboxDGV";
            this.inboxDGV.Size = new System.Drawing.Size(746, 322);
            this.inboxDGV.TabIndex = 0;
            this.inboxDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inboxDGV_CellClick);
            // 
            // messageCategoryL
            // 
            this.messageCategoryL.AutoSize = true;
            this.messageCategoryL.Location = new System.Drawing.Point(24, 51);
            this.messageCategoryL.Name = "messageCategoryL";
            this.messageCategoryL.Size = new System.Drawing.Size(127, 13);
            this.messageCategoryL.TabIndex = 2;
            this.messageCategoryL.Text = "Εισερχόμενα Μηνύματα";
            // 
            // deleteMessageB
            // 
            this.deleteMessageB.Location = new System.Drawing.Point(681, 423);
            this.deleteMessageB.Name = "deleteMessageB";
            this.deleteMessageB.Size = new System.Drawing.Size(89, 30);
            this.deleteMessageB.TabIndex = 3;
            this.deleteMessageB.Text = "Διαγραφή";
            this.deleteMessageB.UseVisualStyleBackColor = true;
            this.deleteMessageB.Click += new System.EventHandler(this.deleteMessageB_Click);
            // 
            // answerMessageB
            // 
            this.answerMessageB.Location = new System.Drawing.Point(815, 423);
            this.answerMessageB.Name = "answerMessageB";
            this.answerMessageB.Size = new System.Drawing.Size(87, 30);
            this.answerMessageB.TabIndex = 4;
            this.answerMessageB.Text = "Απάντηση";
            this.answerMessageB.UseVisualStyleBackColor = true;
            this.answerMessageB.Click += new System.EventHandler(this.answerMessageB_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(12, 135);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(138, 88);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // myGarage_Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 467);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.answerMessageB);
            this.Controls.Add(this.deleteMessageB);
            this.Controls.Add(this.messageCategoryL);
            this.Controls.Add(this.inboxDGV);
            this.Name = "myGarage_Inbox";
            this.Text = "myGarage_Inbox";
            ((System.ComponentModel.ISupportInitialize)(this.inboxDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView inboxDGV;
        private System.Windows.Forms.Label messageCategoryL;
        private System.Windows.Forms.Button deleteMessageB;
        private System.Windows.Forms.Button answerMessageB;
        private System.Windows.Forms.ListView listView1;
    }
}