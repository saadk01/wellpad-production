namespace CPRG253.FinalAsgn.WellProduction
{
    partial class OilProductionForm
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
            this.uxWellPads = new System.Windows.Forms.ComboBox();
            this.uxProdWell = new System.Windows.Forms.ComboBox();
            this.uxNumBarrels = new System.Windows.Forms.TextBox();
            this.uxProdDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxAddOilProd = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxWellPads
            // 
            this.uxWellPads.FormattingEnabled = true;
            this.uxWellPads.Location = new System.Drawing.Point(153, 21);
            this.uxWellPads.Name = "uxWellPads";
            this.uxWellPads.Size = new System.Drawing.Size(200, 21);
            this.uxWellPads.TabIndex = 1;
            this.uxWellPads.SelectionChangeCommitted += new System.EventHandler(this.uxWellPads_SelectionChangeCommitted);
            // 
            // uxProdWell
            // 
            this.uxProdWell.FormattingEnabled = true;
            this.uxProdWell.Location = new System.Drawing.Point(153, 64);
            this.uxProdWell.Name = "uxProdWell";
            this.uxProdWell.Size = new System.Drawing.Size(200, 21);
            this.uxProdWell.TabIndex = 2;
            // 
            // uxNumBarrels
            // 
            this.uxNumBarrels.Location = new System.Drawing.Point(153, 115);
            this.uxNumBarrels.Name = "uxNumBarrels";
            this.uxNumBarrels.Size = new System.Drawing.Size(200, 20);
            this.uxNumBarrels.TabIndex = 3;
            // 
            // uxProdDate
            // 
            this.uxProdDate.Location = new System.Drawing.Point(153, 155);
            this.uxProdDate.Name = "uxProdDate";
            this.uxProdDate.Size = new System.Drawing.Size(200, 20);
            this.uxProdDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Associated Well Pad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Associated Prod. Well:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Daily Number of Barrels:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Production Date:";
            // 
            // uxAddOilProd
            // 
            this.uxAddOilProd.Location = new System.Drawing.Point(153, 205);
            this.uxAddOilProd.Name = "uxAddOilProd";
            this.uxAddOilProd.Size = new System.Drawing.Size(75, 23);
            this.uxAddOilProd.TabIndex = 5;
            this.uxAddOilProd.Text = "Add";
            this.uxAddOilProd.UseVisualStyleBackColor = true;
            this.uxAddOilProd.Click += new System.EventHandler(this.uxAddOilProd_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(278, 205);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 6;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // OilProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 246);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxAddOilProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxProdDate);
            this.Controls.Add(this.uxNumBarrels);
            this.Controls.Add(this.uxProdWell);
            this.Controls.Add(this.uxWellPads);
            this.MaximizeBox = false;
            this.Name = "OilProductionForm";
            this.Text = "Log Oil Production";
            this.Load += new System.EventHandler(this.OilProductionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxWellPads;
        private System.Windows.Forms.ComboBox uxProdWell;
        private System.Windows.Forms.TextBox uxNumBarrels;
        private System.Windows.Forms.DateTimePicker uxProdDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uxAddOilProd;
        private System.Windows.Forms.Button uxCancel;
    }
}