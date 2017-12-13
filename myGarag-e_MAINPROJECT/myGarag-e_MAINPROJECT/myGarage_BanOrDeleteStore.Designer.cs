namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_BanOrDeleteStore
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
            this.SystemAdminTbAnazitisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.withNameRB = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SystemAdminBtnBanKatastima = new System.Windows.Forms.Button();
            this.SystemAdminBtnDeleteKatastima = new System.Windows.Forms.Button();
            this.DokimastikoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemAdminTbAnazitisi
            // 
            this.SystemAdminTbAnazitisi.Location = new System.Drawing.Point(36, 33);
            this.SystemAdminTbAnazitisi.Name = "SystemAdminTbAnazitisi";
            this.SystemAdminTbAnazitisi.Size = new System.Drawing.Size(215, 20);
            this.SystemAdminTbAnazitisi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Αναζήτηση";
            // 
            // withNameRB
            // 
            this.withNameRB.AutoSize = true;
            this.withNameRB.Location = new System.Drawing.Point(36, 70);
            this.withNameRB.Name = "withNameRB";
            this.withNameRB.Size = new System.Drawing.Size(73, 17);
            this.withNameRB.TabIndex = 2;
            this.withNameRB.TabStop = true;
            this.withNameRB.Text = "Με όνομα";
            this.withNameRB.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(126, 70);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Με κατάστημα";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::myGarag_e_MAINPROJECT.Properties.Resources.magnifier_1093184_960_720;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchBtn.Location = new System.Drawing.Point(257, 27);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(32, 31);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DokimastikoLabel);
            this.panel1.Controls.Add(this.SystemAdminBtnDeleteKatastima);
            this.panel1.Controls.Add(this.SystemAdminBtnBanKatastima);
            this.panel1.Location = new System.Drawing.Point(13, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 202);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // SystemAdminBtnBanKatastima
            // 
            this.SystemAdminBtnBanKatastima.Location = new System.Drawing.Point(4, 20);
            this.SystemAdminBtnBanKatastima.Name = "SystemAdminBtnBanKatastima";
            this.SystemAdminBtnBanKatastima.Size = new System.Drawing.Size(129, 23);
            this.SystemAdminBtnBanKatastima.TabIndex = 0;
            this.SystemAdminBtnBanKatastima.Text = "Αποκλεισμός";
            this.SystemAdminBtnBanKatastima.UseVisualStyleBackColor = true;
            // 
            // SystemAdminBtnDeleteKatastima
            // 
            this.SystemAdminBtnDeleteKatastima.Location = new System.Drawing.Point(169, 19);
            this.SystemAdminBtnDeleteKatastima.Name = "SystemAdminBtnDeleteKatastima";
            this.SystemAdminBtnDeleteKatastima.Size = new System.Drawing.Size(135, 23);
            this.SystemAdminBtnDeleteKatastima.TabIndex = 1;
            this.SystemAdminBtnDeleteKatastima.Text = "Διαγραφή";
            this.SystemAdminBtnDeleteKatastima.UseVisualStyleBackColor = true;
            // 
            // DokimastikoLabel
            // 
            this.DokimastikoLabel.Location = new System.Drawing.Point(67, 105);
            this.DokimastikoLabel.Name = "DokimastikoLabel";
            this.DokimastikoLabel.Size = new System.Drawing.Size(179, 23);
            this.DokimastikoLabel.TabIndex = 2;
            this.DokimastikoLabel.Text = "label2";
            // 
            // myGarage_BanOrDeleteStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.withNameRB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SystemAdminTbAnazitisi);
            this.Name = "myGarage_BanOrDeleteStore";
            this.Text = "Μεταβολή στοιχείων καταστήματος";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myGarage_BanOrDeleteStore_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SystemAdminTbAnazitisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton withNameRB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SystemAdminBtnBanKatastima;
        private System.Windows.Forms.Button SystemAdminBtnDeleteKatastima;
        private System.Windows.Forms.Label DokimastikoLabel;
    }
}