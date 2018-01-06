namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_NewMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.sendMesageB = new System.Windows.Forms.Button();
            this.receiverInfoCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // messageTB
            // 
            this.messageTB.Location = new System.Drawing.Point(113, 125);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(310, 179);
            this.messageTB.TabIndex = 3;
            this.messageTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sendMesageB
            // 
            this.sendMesageB.Location = new System.Drawing.Point(382, 319);
            this.sendMesageB.Name = "sendMesageB";
            this.sendMesageB.Size = new System.Drawing.Size(130, 28);
            this.sendMesageB.TabIndex = 4;
            this.sendMesageB.Text = "Αποστολή Μηνύματος";
            this.sendMesageB.UseVisualStyleBackColor = true;
            this.sendMesageB.Click += new System.EventHandler(this.sendMesageB_Click);
            // 
            // receiverInfoCB
            // 
            this.receiverInfoCB.FormattingEnabled = true;
            this.receiverInfoCB.Location = new System.Drawing.Point(142, 56);
            this.receiverInfoCB.Name = "receiverInfoCB";
            this.receiverInfoCB.Size = new System.Drawing.Size(235, 21);
            this.receiverInfoCB.TabIndex = 5;
            // 
            // myGarage_NewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 371);
            this.Controls.Add(this.receiverInfoCB);
            this.Controls.Add(this.sendMesageB);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "myGarage_NewMessage";
            this.Text = "myGarage_NewMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.Button sendMesageB;
        private System.Windows.Forms.ComboBox receiverInfoCB;
    }
}