namespace CPRG253.FinalAsgn.WellProduction
{
    partial class AddWellPadForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxId = new System.Windows.Forms.TextBox();
            this.uxLocation = new System.Windows.Forms.TextBox();
            this.uxProvinces = new System.Windows.Forms.ComboBox();
            this.uxAddWellPad = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Province:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location:";
            // 
            // uxId
            // 
            this.uxId.Location = new System.Drawing.Point(87, 25);
            this.uxId.Name = "uxId";
            this.uxId.Size = new System.Drawing.Size(121, 20);
            this.uxId.TabIndex = 1;
            // 
            // uxLocation
            // 
            this.uxLocation.Location = new System.Drawing.Point(87, 103);
            this.uxLocation.Name = "uxLocation";
            this.uxLocation.Size = new System.Drawing.Size(121, 20);
            this.uxLocation.TabIndex = 3;
            // 
            // uxProvinces
            // 
            this.uxProvinces.FormattingEnabled = true;
            this.uxProvinces.Location = new System.Drawing.Point(87, 66);
            this.uxProvinces.Name = "uxProvinces";
            this.uxProvinces.Size = new System.Drawing.Size(121, 21);
            this.uxProvinces.TabIndex = 2;
            // 
            // uxAddWellPad
            // 
            this.uxAddWellPad.Location = new System.Drawing.Point(27, 149);
            this.uxAddWellPad.Name = "uxAddWellPad";
            this.uxAddWellPad.Size = new System.Drawing.Size(75, 23);
            this.uxAddWellPad.TabIndex = 4;
            this.uxAddWellPad.Text = "Add";
            this.uxAddWellPad.UseVisualStyleBackColor = true;
            this.uxAddWellPad.Click += new System.EventHandler(this.uxAddWellPad_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(133, 149);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 5;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // AddWellPadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 196);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxAddWellPad);
            this.Controls.Add(this.uxProvinces);
            this.Controls.Add(this.uxLocation);
            this.Controls.Add(this.uxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddWellPadForm";
            this.Text = "Add Well Pad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxId;
        private System.Windows.Forms.TextBox uxLocation;
        private System.Windows.Forms.ComboBox uxProvinces;
        private System.Windows.Forms.Button uxAddWellPad;
        private System.Windows.Forms.Button uxCancel;
    }
}