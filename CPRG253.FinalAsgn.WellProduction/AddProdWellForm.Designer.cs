namespace CPRG253.FinalAsgn.WellProduction
{
    partial class AddProdWellForm
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
            this.uxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxWellPads = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxSpudDate = new System.Windows.Forms.DateTimePicker();
            this.uxAddProdWell = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxId
            // 
            this.uxId.Location = new System.Drawing.Point(155, 30);
            this.uxId.Name = "uxId";
            this.uxId.Size = new System.Drawing.Size(200, 20);
            this.uxId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Associated Well Pad:";
            // 
            // uxWellPads
            // 
            this.uxWellPads.FormattingEnabled = true;
            this.uxWellPads.Location = new System.Drawing.Point(155, 73);
            this.uxWellPads.Name = "uxWellPads";
            this.uxWellPads.Size = new System.Drawing.Size(200, 21);
            this.uxWellPads.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Spud Date:";
            // 
            // uxSpudDate
            // 
            this.uxSpudDate.Location = new System.Drawing.Point(155, 121);
            this.uxSpudDate.Name = "uxSpudDate";
            this.uxSpudDate.Size = new System.Drawing.Size(200, 20);
            this.uxSpudDate.TabIndex = 3;
            // 
            // uxAddProdWell
            // 
            this.uxAddProdWell.Location = new System.Drawing.Point(155, 180);
            this.uxAddProdWell.Name = "uxAddProdWell";
            this.uxAddProdWell.Size = new System.Drawing.Size(75, 23);
            this.uxAddProdWell.TabIndex = 4;
            this.uxAddProdWell.Text = "Add";
            this.uxAddProdWell.UseVisualStyleBackColor = true;
            this.uxAddProdWell.Click += new System.EventHandler(this.uxAddProdWell_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(280, 180);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 5;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // AddProdWellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 238);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxAddProdWell);
            this.Controls.Add(this.uxSpudDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxWellPads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddProdWellForm";
            this.Text = "Add Production Well";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uxWellPads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker uxSpudDate;
        private System.Windows.Forms.Button uxAddProdWell;
        private System.Windows.Forms.Button uxCancel;
    }
}