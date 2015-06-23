namespace Ozgrid
{
    partial class ufRangeToClipboard
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
            this.frValues = new System.Windows.Forms.GroupBox();
            this.optValues = new System.Windows.Forms.RadioButton();
            this.optA1 = new System.Windows.Forms.RadioButton();
            this.optR1C1 = new System.Windows.Forms.RadioButton();
            this.frTag = new System.Windows.Forms.GroupBox();
            this.optNone = new System.Windows.Forms.RadioButton();
            this.optCode = new System.Windows.Forms.RadioButton();
            this.optOz = new System.Windows.Forms.RadioButton();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.frValues.SuspendLayout();
            this.frTag.SuspendLayout();
            this.SuspendLayout();
            // 
            // frValues
            // 
            this.frValues.Controls.Add(this.optR1C1);
            this.frValues.Controls.Add(this.optA1);
            this.frValues.Controls.Add(this.optValues);
            this.frValues.Location = new System.Drawing.Point(12, 12);
            this.frValues.Name = "frValues";
            this.frValues.Size = new System.Drawing.Size(247, 194);
            this.frValues.TabIndex = 0;
            this.frValues.TabStop = false;
            this.frValues.Text = "Values/Formula";
            this.frValues.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // optValues
            // 
            this.optValues.AutoSize = true;
            this.optValues.Location = new System.Drawing.Point(6, 38);
            this.optValues.Name = "optValues";
            this.optValues.Size = new System.Drawing.Size(109, 29);
            this.optValues.TabIndex = 0;
            this.optValues.TabStop = true;
            this.optValues.Text = "Values";
            this.optValues.UseVisualStyleBackColor = true;
            this.optValues.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // optA1
            // 
            this.optA1.AutoSize = true;
            this.optA1.Location = new System.Drawing.Point(6, 86);
            this.optA1.Name = "optA1";
            this.optA1.Size = new System.Drawing.Size(164, 29);
            this.optA1.TabIndex = 0;
            this.optA1.TabStop = true;
            this.optA1.Text = "Formulas A1";
            this.optA1.UseVisualStyleBackColor = true;
            // 
            // optR1C1
            // 
            this.optR1C1.AutoSize = true;
            this.optR1C1.Location = new System.Drawing.Point(6, 134);
            this.optR1C1.Name = "optR1C1";
            this.optR1C1.Size = new System.Drawing.Size(192, 29);
            this.optR1C1.TabIndex = 0;
            this.optR1C1.TabStop = true;
            this.optR1C1.Text = "Formulas R1C1";
            this.optR1C1.UseVisualStyleBackColor = true;
            // 
            // frTag
            // 
            this.frTag.Controls.Add(this.optNone);
            this.frTag.Controls.Add(this.optCode);
            this.frTag.Controls.Add(this.optOz);
            this.frTag.Location = new System.Drawing.Point(289, 12);
            this.frTag.Name = "frTag";
            this.frTag.Size = new System.Drawing.Size(247, 194);
            this.frTag.TabIndex = 0;
            this.frTag.TabStop = false;
            this.frTag.Text = "Tag";
            this.frTag.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // optNone
            // 
            this.optNone.AutoSize = true;
            this.optNone.Location = new System.Drawing.Point(6, 134);
            this.optNone.Name = "optNone";
            this.optNone.Size = new System.Drawing.Size(91, 29);
            this.optNone.TabIndex = 0;
            this.optNone.TabStop = true;
            this.optNone.Text = "none";
            this.optNone.UseVisualStyleBackColor = true;
            this.optNone.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // optCode
            // 
            this.optCode.AutoSize = true;
            this.optCode.Location = new System.Drawing.Point(6, 86);
            this.optCode.Name = "optCode";
            this.optCode.Size = new System.Drawing.Size(185, 29);
            this.optCode.TabIndex = 0;
            this.optCode.TabStop = true;
            this.optCode.Text = "[code]...[/code]";
            this.optCode.UseVisualStyleBackColor = true;
            // 
            // optOz
            // 
            this.optOz.AutoSize = true;
            this.optOz.Location = new System.Drawing.Point(6, 38);
            this.optOz.Name = "optOz";
            this.optOz.Size = new System.Drawing.Size(155, 29);
            this.optOz.TabIndex = 0;
            this.optOz.TabStop = true;
            this.optOz.Text = "[ss=...]*[/ss]";
            this.optOz.UseVisualStyleBackColor = true;
            this.optOz.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cmdCopy
            // 
            this.cmdCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCopy.Location = new System.Drawing.Point(316, 224);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(144, 60);
            this.cmdCopy.TabIndex = 1;
            this.cmdCopy.Text = "Copy";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // ufRangeToClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 316);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.frTag);
            this.Controls.Add(this.frValues);
            this.Name = "ufRangeToClipboard";
            this.Text = "Copy Range To Clipboard";
            this.frValues.ResumeLayout(false);
            this.frValues.PerformLayout();
            this.frTag.ResumeLayout(false);
            this.frTag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox frValues;
        private System.Windows.Forms.RadioButton optR1C1;
        private System.Windows.Forms.RadioButton optA1;
        private System.Windows.Forms.RadioButton optValues;
        private System.Windows.Forms.GroupBox frTag;
        private System.Windows.Forms.RadioButton optNone;
        private System.Windows.Forms.RadioButton optCode;
        private System.Windows.Forms.RadioButton optOz;
        private System.Windows.Forms.Button cmdCopy;
    }
}