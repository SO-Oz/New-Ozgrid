namespace Ozgrid
{
    partial class WorkbookList
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
            this.lbWorkbooks = new System.Windows.Forms.ListBox();
            this.cmdRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWorkbooks
            // 
            this.lbWorkbooks.FormattingEnabled = true;
            this.lbWorkbooks.ItemHeight = 25;
            this.lbWorkbooks.Location = new System.Drawing.Point(7, 75);
            this.lbWorkbooks.Name = "lbWorkbooks";
            this.lbWorkbooks.Size = new System.Drawing.Size(412, 154);
            this.lbWorkbooks.TabIndex = 0;
            // 
            // cmdRun
            // 
            this.cmdRun.Location = new System.Drawing.Point(76, 247);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(253, 54);
            this.cmdRun.TabIndex = 1;
            this.cmdRun.Text = "Use Selection";
            this.cmdRun.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Workbooks in current instance:";
            // 
            // WorkbookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdRun);
            this.Controls.Add(this.lbWorkbooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkbookList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Workbook";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWorkbooks;
        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.Label label1;
    }
}