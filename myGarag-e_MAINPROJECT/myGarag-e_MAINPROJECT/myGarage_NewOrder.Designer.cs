namespace myGarag_e_MAINPROJECT
{
    partial class myGarage_NewOrder
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
            this.NewOrderEdit = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderCheckBOloklirwthike = new System.Windows.Forms.CheckBox();
            this.OrderTbPelatologioKatastimatarxisKatID = new System.Windows.Forms.TextBox();
            this.OrderTbPelatologioPeID = new System.Windows.Forms.TextBox();
            this.NewOrderEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewOrderEdit
            // 
            this.NewOrderEdit.Controls.Add(this.label4);
            this.NewOrderEdit.Controls.Add(this.label3);
            this.NewOrderEdit.Controls.Add(this.label2);
            this.NewOrderEdit.Controls.Add(this.OrderCheckBOloklirwthike);
            this.NewOrderEdit.Controls.Add(this.OrderTbPelatologioKatastimatarxisKatID);
            this.NewOrderEdit.Controls.Add(this.OrderTbPelatologioPeID);
            this.NewOrderEdit.Location = new System.Drawing.Point(2, 65);
            this.NewOrderEdit.Name = "NewOrderEdit";
            this.NewOrderEdit.Size = new System.Drawing.Size(275, 182);
            this.NewOrderEdit.TabIndex = 0;
            this.NewOrderEdit.TabStop = false;
            this.NewOrderEdit.Text = "Επεξεργασία";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ολοκληρώθηκε;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Κωδικός Καταστηματάρχη:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Κωδικός Πελατολογίου:";
            // 
            // OrderCheckBOloklirwthike
            // 
            this.OrderCheckBOloklirwthike.AutoSize = true;
            this.OrderCheckBOloklirwthike.Location = new System.Drawing.Point(156, 120);
            this.OrderCheckBOloklirwthike.Name = "OrderCheckBOloklirwthike";
            this.OrderCheckBOloklirwthike.Size = new System.Drawing.Size(66, 17);
            this.OrderCheckBOloklirwthike.TabIndex = 3;
            this.OrderCheckBOloklirwthike.Text = "Ναί\\Όχι";
            this.OrderCheckBOloklirwthike.UseVisualStyleBackColor = true;
            // 
            // OrderTbPelatologioKatastimatarxisKatID
            // 
            this.OrderTbPelatologioKatastimatarxisKatID.Location = new System.Drawing.Point(156, 77);
            this.OrderTbPelatologioKatastimatarxisKatID.Name = "OrderTbPelatologioKatastimatarxisKatID";
            this.OrderTbPelatologioKatastimatarxisKatID.Size = new System.Drawing.Size(48, 20);
            this.OrderTbPelatologioKatastimatarxisKatID.TabIndex = 2;
            // 
            // OrderTbPelatologioPeID
            // 
            this.OrderTbPelatologioPeID.Location = new System.Drawing.Point(156, 29);
            this.OrderTbPelatologioPeID.Name = "OrderTbPelatologioPeID";
            this.OrderTbPelatologioPeID.Size = new System.Drawing.Size(48, 20);
            this.OrderTbPelatologioPeID.TabIndex = 1;
            // 
            // myGarage_NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 257);
            this.Controls.Add(this.NewOrderEdit);
            this.Name = "myGarage_NewOrder";
            this.Text = "Προσθήκη νέας παραγγελίας";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myGarage_NewOrder_FormClosed);
            this.NewOrderEdit.ResumeLayout(false);
            this.NewOrderEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewOrderEdit;
        private System.Windows.Forms.TextBox OrderTbPelatologioKatastimatarxisKatID;
        private System.Windows.Forms.TextBox OrderTbPelatologioPeID;
        private System.Windows.Forms.CheckBox OrderCheckBOloklirwthike;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}