namespace CPRG253.FinalAsgn.WellProduction
{
    partial class AddInjWellForm
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
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxAddInjWell = new System.Windows.Forms.Button();
            this.uxSpudDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.uxWellPads = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxWaterType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(265, 214);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 6;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxAddInjWell
            // 
            this.uxAddInjWell.Location = new System.Drawing.Point(140, 214);
            this.uxAddInjWell.Name = "uxAddInjWell";
            this.uxAddInjWell.Size = new System.Drawing.Size(75, 23);
            this.uxAddInjWell.TabIndex = 5;
            this.uxAddInjWell.Text = "Add";
            this.uxAddInjWell.UseVisualStyleBackColor = true;
            this.uxAddInjWell.Click += new System.EventHandler(this.uxAddInjWell_Click);
            // 
            // uxSpudDate
            // 
            this.uxSpudDate.Location = new System.Drawing.Point(140, 115);
            this.uxSpudDate.Name = "uxSpudDate";
            this.uxSpudDate.Size = new System.Drawing.Size(200, 20);
            this.uxSpudDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Spud Date:";
            // 
            // uxWellPads
            // 
            this.uxWellPads.FormattingEnabled = true;
            this.uxWellPads.Location = new System.Drawing.Point(140, 67);
            this.uxWellPads.Name = "uxWellPads";
            this.uxWellPads.Size = new System.Drawing.Size(200, 21);
            this.uxWellPads.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Associated Well Pad:";
            // 
            // uxId
            // 
            this.uxId.Location = new System.Drawing.Point(140, 24);
            this.uxId.Name = "uxId";
            this.uxId.Size = new System.Drawing.Size(200, 20);
            this.uxId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // uxWaterType
            // 
            this.uxWaterType.FormattingEnabled = true;
            this.uxWaterType.Location = new System.Drawing.Point(140, 160);
            this.uxWaterType.Name = "uxWaterType";
            this.uxWaterType.Size = new System.Drawing.Size(200, 21);
            this.uxWaterType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Water Type:";
            // 
            // AddInjWellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxWaterType);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxAddInjWell);
            this.Controls.Add(this.uxSpudDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxWellPads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddInjWellForm";
            this.Text = "Add Injection Well";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxAddInjWell;
        private System.Windows.Forms.DateTimePicker uxSpudDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uxWellPads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uxWaterType;
        private System.Windows.Forms.Label label4;
    }
}