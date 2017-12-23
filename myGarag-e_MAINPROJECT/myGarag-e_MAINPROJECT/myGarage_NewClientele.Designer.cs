namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_NewClientele
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
            this.NewClienteleEdit = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteleTbKatID = new System.Windows.Forms.TextBox();
            this.ClienteleTbKodikosPelati = new System.Windows.Forms.TextBox();
            this.ClienteleTbKodikosPelatologiou = new System.Windows.Forms.TextBox();
            this.NewClienteleEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewClienteleEdit
            // 
            this.NewClienteleEdit.Controls.Add(this.label3);
            this.NewClienteleEdit.Controls.Add(this.label2);
            this.NewClienteleEdit.Controls.Add(this.label1);
            this.NewClienteleEdit.Controls.Add(this.ClienteleTbKatID);
            this.NewClienteleEdit.Controls.Add(this.ClienteleTbKodikosPelati);
            this.NewClienteleEdit.Controls.Add(this.ClienteleTbKodikosPelatologiou);
            this.NewClienteleEdit.Location = new System.Drawing.Point(2, 82);
            this.NewClienteleEdit.Name = "NewClienteleEdit";
            this.NewClienteleEdit.Size = new System.Drawing.Size(259, 164);
            this.NewClienteleEdit.TabIndex = 1;
            this.NewClienteleEdit.TabStop = false;
            this.NewClienteleEdit.Text = "Επεξεργασία";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Κωδικός καταστηματάρχη:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Κωδικός πελάτη:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Κωδικός πελατολογίου:";
            // 
            // ClienteleTbKatID
            // 
            this.ClienteleTbKatID.Location = new System.Drawing.Point(159, 106);
            this.ClienteleTbKatID.Name = "ClienteleTbKatID";
            this.ClienteleTbKatID.Size = new System.Drawing.Size(48, 20);
            this.ClienteleTbKatID.TabIndex = 2;
            // 
            // ClienteleTbKodikosPelati
            // 
            this.ClienteleTbKodikosPelati.Location = new System.Drawing.Point(159, 58);
            this.ClienteleTbKodikosPelati.Name = "ClienteleTbKodikosPelati";
            this.ClienteleTbKodikosPelati.Size = new System.Drawing.Size(48, 20);
            this.ClienteleTbKodikosPelati.TabIndex = 1;
            // 
            // ClienteleTbKodikosPelatologiou
            // 
            this.ClienteleTbKodikosPelatologiou.Location = new System.Drawing.Point(159, 19);
            this.ClienteleTbKodikosPelatologiou.Name = "ClienteleTbKodikosPelatologiou";
            this.ClienteleTbKodikosPelatologiou.Size = new System.Drawing.Size(48, 20);
            this.ClienteleTbKodikosPelatologiou.TabIndex = 0;
            // 
            // myGarage_NewClientele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 249);
            this.Controls.Add(this.NewClienteleEdit);
            this.Name = "myGarage_NewClientele";
            this.Text = "Εισαγωγή νέου πελατολογίου";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myGarage_NewClientele_FormClosed);
            this.NewClienteleEdit.ResumeLayout(false);
            this.NewClienteleEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewClienteleEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClienteleTbKatID;
        private System.Windows.Forms.TextBox ClienteleTbKodikosPelati;
        private System.Windows.Forms.TextBox ClienteleTbKodikosPelatologiou;
    }
}