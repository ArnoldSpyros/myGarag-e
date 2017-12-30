namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_genericTerminateOrLogoutForm
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
            this.terminateprogBtn = new System.Windows.Forms.Button();
            this.logoutuserBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Θέλετε να τερματίσετε την εφαρμογή;";
            // 
            // terminateprogBtn
            // 
            this.terminateprogBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.terminateprogBtn.Location = new System.Drawing.Point(12, 51);
            this.terminateprogBtn.Name = "terminateprogBtn";
            this.terminateprogBtn.Size = new System.Drawing.Size(109, 35);
            this.terminateprogBtn.TabIndex = 1;
            this.terminateprogBtn.Text = "Κλείσιμο προγράμματος";
            this.terminateprogBtn.UseVisualStyleBackColor = true;
            // 
            // logoutuserBtn
            // 
            this.logoutuserBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.logoutuserBtn.Location = new System.Drawing.Point(146, 51);
            this.logoutuserBtn.Name = "logoutuserBtn";
            this.logoutuserBtn.Size = new System.Drawing.Size(116, 35);
            this.logoutuserBtn.TabIndex = 2;
            this.logoutuserBtn.Text = "Αποσύνδεση χρήστη";
            this.logoutuserBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(285, 51);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(114, 34);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Ακύρωση";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // myGarage_genericTerminateOrLogoutForm
            // 
            this.AcceptButton = this.terminateprogBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(411, 106);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.logoutuserBtn);
            this.Controls.Add(this.terminateprogBtn);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "myGarage_genericTerminateOrLogoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ερώτηση";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button terminateprogBtn;
        private System.Windows.Forms.Button logoutuserBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}