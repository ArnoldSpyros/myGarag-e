namespace myGarag_e_MAINPROJECT
{
    partial class AppointmentForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.reasonRTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.hourCombo = new System.Windows.Forms.ComboBox();
            this.minutesCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelB = new System.Windows.Forms.Button();
            this.sendB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ΝΕΟ ΡΑΝΤΕΒΟΥ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ονοματεπώνυμο";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ποιος είναι ο λόγος αίτησης ραντεβού;";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(130, 100);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 3;
            // 
            // reasonRTB
            // 
            this.reasonRTB.Location = new System.Drawing.Point(242, 237);
            this.reasonRTB.Name = "reasonRTB";
            this.reasonRTB.Size = new System.Drawing.Size(178, 92);
            this.reasonRTB.TabIndex = 4;
            this.reasonRTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ημερομηνία";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Επιλογή Καταστήματος";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(130, 186);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ώρα";
            // 
            // hourCombo
            // 
            this.hourCombo.FormattingEnabled = true;
            this.hourCombo.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.hourCombo.Location = new System.Drawing.Point(373, 186);
            this.hourCombo.Name = "hourCombo";
            this.hourCombo.Size = new System.Drawing.Size(47, 21);
            this.hourCombo.TabIndex = 10;
            // 
            // minutesCombo
            // 
            this.minutesCombo.FormattingEnabled = true;
            this.minutesCombo.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.minutesCombo.Location = new System.Drawing.Point(442, 186);
            this.minutesCombo.Name = "minutesCombo";
            this.minutesCombo.Size = new System.Drawing.Size(47, 21);
            this.minutesCombo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(30, 352);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(148, 23);
            this.cancelB.TabIndex = 13;
            this.cancelB.Text = "Ακύρωση και Επιστροφή";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // sendB
            // 
            this.sendB.Location = new System.Drawing.Point(467, 352);
            this.sendB.Name = "sendB";
            this.sendB.Size = new System.Drawing.Size(75, 23);
            this.sendB.TabIndex = 14;
            this.sendB.Text = "Αποστολή";
            this.sendB.UseVisualStyleBackColor = true;
            this.sendB.Click += new System.EventHandler(this.sendB_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 387);
            this.Controls.Add(this.sendB);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minutesCombo);
            this.Controls.Add(this.hourCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reasonRTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentForm";
            this.Text = "RantebouForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppointmentForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.RichTextBox reasonRTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox hourCombo;
        private System.Windows.Forms.ComboBox minutesCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button sendB;
    }
}