namespace CPRG253.FinalAsgn.WellProduction
{
    partial class ViewOilProductionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxProdWell = new System.Windows.Forms.ComboBox();
            this.uxWellPads = new System.Windows.Forms.ComboBox();
            this.uxProductionLog = new System.Windows.Forms.ListView();
            this.uxViewProduction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Associated Prod. Well:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Associated Well Pad:";
            // 
            // uxProdWell
            // 
            this.uxProdWell.FormattingEnabled = true;
            this.uxProdWell.Location = new System.Drawing.Point(151, 72);
            this.uxProdWell.Name = "uxProdWell";
            this.uxProdWell.Size = new System.Drawing.Size(200, 21);
            this.uxProdWell.TabIndex = 15;
            // 
            // uxWellPads
            // 
            this.uxWellPads.FormattingEnabled = true;
            this.uxWellPads.Location = new System.Drawing.Point(151, 29);
            this.uxWellPads.Name = "uxWellPads";
            this.uxWellPads.Size = new System.Drawing.Size(200, 21);
            this.uxWellPads.TabIndex = 14;
            this.uxWellPads.SelectionChangeCommitted += new System.EventHandler(this.uxWellPads_SelectionChangeCommitted);
            // 
            // uxProductionLog
            // 
            this.uxProductionLog.Location = new System.Drawing.Point(28, 182);
            this.uxProductionLog.Name = "uxProductionLog";
            this.uxProductionLog.Size = new System.Drawing.Size(323, 194);
            this.uxProductionLog.TabIndex = 18;
            this.uxProductionLog.UseCompatibleStateImageBehavior = false;
            this.uxProductionLog.View = System.Windows.Forms.View.Details;
            // 
            // uxViewProduction
            // 
            this.uxViewProduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uxViewProduction.Location = new System.Drawing.Point(276, 124);
            this.uxViewProduction.Name = "uxViewProduction";
            this.uxViewProduction.Size = new System.Drawing.Size(75, 23);
            this.uxViewProduction.TabIndex = 19;
            this.uxViewProduction.Text = "View";
            this.uxViewProduction.UseVisualStyleBackColor = true;
            this.uxViewProduction.Click += new System.EventHandler(this.uxViewProduction_Click);
            // 
            // ViewOilProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 408);
            this.Controls.Add(this.uxViewProduction);
            this.Controls.Add(this.uxProductionLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxProdWell);
            this.Controls.Add(this.uxWellPads);
            this.MaximizeBox = false;
            this.Name = "ViewOilProductionForm";
            this.Text = "View Oil Production";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uxProdWell;
        private System.Windows.Forms.ComboBox uxWellPads;
        private System.Windows.Forms.ListView uxProductionLog;
        private System.Windows.Forms.Button uxViewProduction;
    }
}