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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Εισερχόμενα");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Απεσταλμένα");
            this.inboxDGV = new System.Windows.Forms.DataGridView();
            this.deleteMessageB = new System.Windows.Forms.Button();
            this.answerMessageB = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.inboxDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inboxDGV
            // 
            this.inboxDGV.AllowUserToAddRows = false;
            this.inboxDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inboxDGV.Location = new System.Drawing.Point(95, 31);
            this.inboxDGV.Name = "inboxDGV";
            this.inboxDGV.Size = new System.Drawing.Size(467, 322);
            this.inboxDGV.TabIndex = 0;
            this.inboxDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inboxDGV_CellClick);
            // 
            // deleteMessageB
            // 
            this.deleteMessageB.Location = new System.Drawing.Point(346, 359);
            this.deleteMessageB.Name = "deleteMessageB";
            this.deleteMessageB.Size = new System.Drawing.Size(89, 30);
            this.deleteMessageB.TabIndex = 3;
            this.deleteMessageB.Text = "Διαγραφή";
            this.deleteMessageB.UseVisualStyleBackColor = true;
            this.deleteMessageB.Click += new System.EventHandler(this.deleteMessageB_Click);
            // 
            // answerMessageB
            // 
            this.answerMessageB.Location = new System.Drawing.Point(475, 359);
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
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(6, 31);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(83, 88);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inboxDGV);
            this.groupBox1.Controls.Add(this.deleteMessageB);
            this.groupBox1.Controls.Add(this.answerMessageB);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 401);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Διαχείριση μηνυμάτων";
            // 
            // myGarage_Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 410);
            this.Controls.Add(this.groupBox1);
            this.Name = "myGarage_Inbox";
            this.Text = "Γραμματοκιβώτιο";
            ((System.ComponentModel.ISupportInitialize)(this.inboxDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView inboxDGV;
        private System.Windows.Forms.Button deleteMessageB;
        private System.Windows.Forms.Button answerMessageB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}