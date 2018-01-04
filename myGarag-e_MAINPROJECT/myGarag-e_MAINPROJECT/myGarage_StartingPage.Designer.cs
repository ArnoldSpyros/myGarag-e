﻿namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_StartingPage
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
            this.components = new System.ComponentModel.Container();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LoginCustomerBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.startingPageErrLabel = new System.Windows.Forms.Label();
            this.loginTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.WelcomeLabel.Location = new System.Drawing.Point(13, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(323, 25);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Καλωσήρθατε στο myGarag-e";
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(116, 67);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(116, 20);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Όνομα χρήστη:";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PassLabel
            // 
            this.PassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(103, 125);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(156, 20);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Κωδικός πρόσβασης:";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserTB
            // 
            this.UserTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UserTB.Location = new System.Drawing.Point(61, 90);
            this.UserTB.MinimumSize = new System.Drawing.Size(252, 20);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(252, 20);
            this.UserTB.TabIndex = 1;
            // 
            // PassTB
            // 
            this.PassTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PassTB.Location = new System.Drawing.Point(61, 160);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(252, 20);
            this.PassTB.TabIndex = 2;
            this.PassTB.UseSystemPasswordChar = true;
            // 
            // LoginCustomerBtn
            // 
            this.LoginCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoginCustomerBtn.Location = new System.Drawing.Point(107, 213);
            this.LoginCustomerBtn.Name = "LoginCustomerBtn";
            this.LoginCustomerBtn.Size = new System.Drawing.Size(152, 23);
            this.LoginCustomerBtn.TabIndex = 3;
            this.LoginCustomerBtn.Text = "Είσοδος";
            this.LoginCustomerBtn.UseVisualStyleBackColor = true;
            this.LoginCustomerBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RegisterBtn.Location = new System.Drawing.Point(107, 267);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(152, 23);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Εγγραφή νέου χρήστη";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // startingPageErrLabel
            // 
            this.startingPageErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.startingPageErrLabel.ForeColor = System.Drawing.Color.Red;
            this.startingPageErrLabel.Location = new System.Drawing.Point(3, 34);
            this.startingPageErrLabel.Name = "startingPageErrLabel";
            this.startingPageErrLabel.Size = new System.Drawing.Size(349, 33);
            this.startingPageErrLabel.TabIndex = 5;
            this.startingPageErrLabel.Text = "Δεν βρέθηκε χρήστης με αυτόν τον συνδυασμό ονόματος και κωδικού";
            this.startingPageErrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startingPageErrLabel.Visible = false;
            // 
            // loginTimer
            // 
            this.loginTimer.Interval = 3000;
            this.loginTimer.Tick += new System.EventHandler(this.loginTimer_Tick);
            // 
            // myGarage_StartingPage
            // 
            this.AcceptButton = this.LoginCustomerBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 302);
            this.Controls.Add(this.startingPageErrLabel);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginCustomerBtn);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UserTB);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.MaximumSize = new System.Drawing.Size(380, 340);
            this.MinimumSize = new System.Drawing.Size(380, 340);
            this.Name = "myGarage_StartingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Είσοδος χρήστη";
            this.EnabledChanged += new System.EventHandler(this.myGarage_StartingPage_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button LoginCustomerBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label startingPageErrLabel;
        private System.Windows.Forms.Timer loginTimer;
    }
}