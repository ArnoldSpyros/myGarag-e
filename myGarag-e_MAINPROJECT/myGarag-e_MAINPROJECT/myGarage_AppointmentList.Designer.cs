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
            this.AppointmentBtnAnaneosi = new System.Windows.Forms.Button();
            this.AppointmentBtnEpibebaiosi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentListGridView
            // 
            this.AppointmentListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentListGridView.Location = new System.Drawing.Point(13, 116);
            this.AppointmentListGridView.Name = "AppointmentListGridView";
            this.AppointmentListGridView.Size = new System.Drawing.Size(349, 238);
            this.AppointmentListGridView.TabIndex = 0;
            // 
            // AppointmentBtnDiagrafi
            // 
            this.AppointmentBtnDiagrafi.Location = new System.Drawing.Point(287, 24);
            this.AppointmentBtnDiagrafi.Name = "AppointmentBtnDiagrafi";
            this.AppointmentBtnDiagrafi.Size = new System.Drawing.Size(75, 23);
            this.AppointmentBtnDiagrafi.TabIndex = 1;
            this.AppointmentBtnDiagrafi.Text = "Διαγραφή";
            this.AppointmentBtnDiagrafi.UseVisualStyleBackColor = true;
            this.AppointmentBtnDiagrafi.Click += new System.EventHandler(this.AppointmentBtnDiagrafi_Click);
            // 
            // AppointmentBtnAnaneosi
            // 
            this.AppointmentBtnAnaneosi.Location = new System.Drawing.Point(13, 24);
            this.AppointmentBtnAnaneosi.Name = "AppointmentBtnAnaneosi";
            this.AppointmentBtnAnaneosi.Size = new System.Drawing.Size(75, 23);
            this.AppointmentBtnAnaneosi.TabIndex = 2;
            this.AppointmentBtnAnaneosi.Text = "Ανανέωση";
            this.AppointmentBtnAnaneosi.UseVisualStyleBackColor = true;
            this.AppointmentBtnAnaneosi.Click += new System.EventHandler(this.AppointmentBtnAnaneosi_Click);
            // 
            // AppointmentBtnEpibebaiosi
            // 
            this.AppointmentBtnEpibebaiosi.Location = new System.Drawing.Point(144, 24);
            this.AppointmentBtnEpibebaiosi.Name = "AppointmentBtnEpibebaiosi";
            this.AppointmentBtnEpibebaiosi.Size = new System.Drawing.Size(97, 23);
            this.AppointmentBtnEpibebaiosi.TabIndex = 3;
            this.AppointmentBtnEpibebaiosi.Text = "Επιβεβαίωση";
            this.AppointmentBtnEpibebaiosi.UseVisualStyleBackColor = true;
            this.AppointmentBtnEpibebaiosi.Click += new System.EventHandler(this.AppointmentBtnEpibebaiosi_Click);
            // 
            // myGarage_AppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 366);
            this.Controls.Add(this.AppointmentBtnEpibebaiosi);
            this.Controls.Add(this.AppointmentBtnAnaneosi);
            this.Controls.Add(this.AppointmentBtnDiagrafi);
            this.Controls.Add(this.AppointmentListGridView);
            this.Name = "myGarage_AppointmentList";
            this.Text = "Λίστα ραντεβού";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myGarage_AppointmentList_FormClosed);
            this.Load += new System.EventHandler(this.myGarage_AppointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentListGridView;
        private System.Windows.Forms.Button AppointmentBtnDiagrafi;
        private System.Windows.Forms.Button AppointmentBtnAnaneosi;
        private System.Windows.Forms.Button AppointmentBtnEpibebaiosi;
    }
}