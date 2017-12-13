namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_AppointmentList
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
            this.AppointmentListGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentBtnDiagrafi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentListGridView
            // 
            this.AppointmentListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentListGridView.Location = new System.Drawing.Point(13, 76);
            this.AppointmentListGridView.Name = "AppointmentListGridView";
            this.AppointmentListGridView.Size = new System.Drawing.Size(259, 174);
            this.AppointmentListGridView.TabIndex = 0;
            // 
            // AppointmentBtnDiagrafi
            // 
            this.AppointmentBtnDiagrafi.Location = new System.Drawing.Point(178, 24);
            this.AppointmentBtnDiagrafi.Name = "AppointmentBtnDiagrafi";
            this.AppointmentBtnDiagrafi.Size = new System.Drawing.Size(75, 23);
            this.AppointmentBtnDiagrafi.TabIndex = 1;
            this.AppointmentBtnDiagrafi.Text = "Διαγραφή";
            this.AppointmentBtnDiagrafi.UseVisualStyleBackColor = true;
            this.AppointmentBtnDiagrafi.Click += new System.EventHandler(this.AppointmentBtnDiagrafi_Click);
            // 
            // myGarage_AppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AppointmentBtnDiagrafi);
            this.Controls.Add(this.AppointmentListGridView);
            this.Name = "myGarage_AppointmentList";
            this.Text = "Λίστα ραντεβού";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myGarage_AppointmentList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentListGridView;
        private System.Windows.Forms.Button AppointmentBtnDiagrafi;
    }
}