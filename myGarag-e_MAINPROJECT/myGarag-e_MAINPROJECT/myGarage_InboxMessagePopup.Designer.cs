namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_InboxMessagePopup
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
            this.msgTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // msgTb
            // 
            this.msgTb.Location = new System.Drawing.Point(12, 12);
            this.msgTb.Multiline = true;
            this.msgTb.Name = "msgTb";
            this.msgTb.ReadOnly = true;
            this.msgTb.Size = new System.Drawing.Size(260, 238);
            this.msgTb.TabIndex = 0;
            // 
            // myGarage_InboxMessagePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.msgTb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "myGarage_InboxMessagePopup";
            this.Text = "Προβολή μηνύματος";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgTb;
    }
}