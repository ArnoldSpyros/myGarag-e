namespace TestApplication
{
    partial class TestingForm
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
            this.mainB = new System.Windows.Forms.Button();
            this.message1L = new System.Windows.Forms.Label();
            this.message2L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainB
            // 
            this.mainB.Location = new System.Drawing.Point(66, 96);
            this.mainB.Name = "mainB";
            this.mainB.Size = new System.Drawing.Size(152, 75);
            this.mainB.TabIndex = 0;
            this.mainB.Text = "Κουμπί!";
            this.mainB.UseVisualStyleBackColor = true;
            this.mainB.Click += new System.EventHandler(this.mainB_Click);
            // 
            // message1L
            // 
            this.message1L.AutoSize = true;
            this.message1L.Location = new System.Drawing.Point(18, 217);
            this.message1L.Name = "message1L";
            this.message1L.Size = new System.Drawing.Size(0, 13);
            this.message1L.TabIndex = 1;
            // 
            // message2L
            // 
            this.message2L.AutoSize = true;
            this.message2L.Location = new System.Drawing.Point(21, 22);
            this.message2L.Name = "message2L";
            this.message2L.Size = new System.Drawing.Size(0, 13);
            this.message2L.TabIndex = 2;
            this.message2L.Click += new System.EventHandler(this.message2L_Cick);
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.message2L);
            this.Controls.Add(this.message1L);
            this.Controls.Add(this.mainB);
            this.Name = "TestingForm";
            this.Text = "Δοκιμαστική Φόρμα";
            this.Load += new System.EventHandler(this.TestingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainB;
        private System.Windows.Forms.Label message1L;
        private System.Windows.Forms.Label message2L;
    }
}

