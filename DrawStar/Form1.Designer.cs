namespace DrawStar
{
    partial class DrawStar
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
            this.xBox = new System.Windows.Forms.TextBox();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(556, 23);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(70, 20);
            this.xBox.TabIndex = 0;
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(556, 94);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(70, 20);
            this.sizeBox.TabIndex = 1;
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(556, 58);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(70, 20);
            this.yBox.TabIndex = 2;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xLabel.Location = new System.Drawing.Point(536, 26);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(523, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(536, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "DRAW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(669, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.xBox);
            this.Name = "DrawStar";
            this.Text = "Star";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

