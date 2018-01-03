namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_NewAppointment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewAppointmentBtnOloklirwsi = new System.Windows.Forms.Button();
            this.NewAppointmentRTbSxolia = new System.Windows.Forms.RichTextBox();
            this.NewAppointmentChbDate = new System.Windows.Forms.DateTimePicker();
            this.NewAppointmentSBKatastima = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewAppointmentBtnOloklirwsi);
            this.groupBox1.Controls.Add(this.NewAppointmentRTbSxolia);
            this.groupBox1.Controls.Add(this.NewAppointmentChbDate);
            this.groupBox1.Controls.Add(this.NewAppointmentSBKatastima);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Νέο ραντεβού";
            // 
            // NewAppointmentBtnOloklirwsi
            // 
            this.NewAppointmentBtnOloklirwsi.Location = new System.Drawing.Point(92, 289);
            this.NewAppointmentBtnOloklirwsi.Name = "NewAppointmentBtnOloklirwsi";
            this.NewAppointmentBtnOloklirwsi.Size = new System.Drawing.Size(147, 23);
            this.NewAppointmentBtnOloklirwsi.TabIndex = 5;
            this.NewAppointmentBtnOloklirwsi.Text = "Ολοκλήρωση";
            this.NewAppointmentBtnOloklirwsi.UseVisualStyleBackColor = true;
            this.NewAppointmentBtnOloklirwsi.Click += new System.EventHandler(this.NewAppointmentBtnOloklirwsi_Click);
            // 
            // NewAppointmentRTbSxolia
            // 
            this.NewAppointmentRTbSxolia.Location = new System.Drawing.Point(123, 135);
            this.NewAppointmentRTbSxolia.Name = "NewAppointmentRTbSxolia";
            this.NewAppointmentRTbSxolia.Size = new System.Drawing.Size(200, 127);
            this.NewAppointmentRTbSxolia.TabIndex = 4;
            this.NewAppointmentRTbSxolia.Text = "";
            // 
            // NewAppointmentChbDate
            // 
            this.NewAppointmentChbDate.Location = new System.Drawing.Point(123, 85);
            this.NewAppointmentChbDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.NewAppointmentChbDate.Name = "NewAppointmentChbDate";
            this.NewAppointmentChbDate.Size = new System.Drawing.Size(200, 20);
            this.NewAppointmentChbDate.TabIndex = 3;
            // 
            // NewAppointmentSBKatastima
            // 
            this.NewAppointmentSBKatastima.FormattingEnabled = true;
            this.NewAppointmentSBKatastima.Location = new System.Drawing.Point(123, 28);
            this.NewAppointmentSBKatastima.Name = "NewAppointmentSBKatastima";
            this.NewAppointmentSBKatastima.Size = new System.Drawing.Size(200, 21);
            this.NewAppointmentSBKatastima.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Σημειώσεις/σχόλια:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Κανονισμένη ημ/νια:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Κατάστημα:";
            // 
            // myGarage_NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 371);
            this.Controls.Add(this.groupBox1);
            this.Name = "myGarage_NewAppointment";
            this.Text = "Δημιουργία νέου ραντεβού";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.myGarage_NewAppointment_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myGarage_NewAppointment_FormClosed);
            this.Load += new System.EventHandler(this.myGarage_NewAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker NewAppointmentChbDate;
        private System.Windows.Forms.ComboBox NewAppointmentSBKatastima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox NewAppointmentRTbSxolia;
        private System.Windows.Forms.Button NewAppointmentBtnOloklirwsi;
    }
}