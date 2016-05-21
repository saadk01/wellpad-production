namespace CPRG253.FinalAsgn.WellProduction
{
    partial class Explorer
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
            this.uxTree = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.uxDetails = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // uxTree
            // 
            this.uxTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.uxTree.Location = new System.Drawing.Point(0, 0);
            this.uxTree.Name = "uxTree";
            this.uxTree.Size = new System.Drawing.Size(157, 396);
            this.uxTree.TabIndex = 0;
            this.uxTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.uxTree_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(157, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 396);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // uxDetails
            // 
            this.uxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxDetails.Location = new System.Drawing.Point(160, 0);
            this.uxDetails.Name = "uxDetails";
            this.uxDetails.Size = new System.Drawing.Size(345, 396);
            this.uxDetails.TabIndex = 2;
            this.uxDetails.UseCompatibleStateImageBehavior = false;
            this.uxDetails.View = System.Windows.Forms.View.Details;
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 396);
            this.Controls.Add(this.uxDetails);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.uxTree);
            this.Name = "Explorer";
            this.Text = "Well Pad Explorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView uxTree;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView uxDetails;
    }
}