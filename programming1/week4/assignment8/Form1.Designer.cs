namespace assignment8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labEquality = new System.Windows.Forms.Label();
            this.compare = new System.Windows.Forms.Button();
            this.inpNumber = new System.Windows.Forms.TextBox();
            this.labSum = new System.Windows.Forms.Label();
            this.labMult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number (n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "sum = 1 + 2 + ... + n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "sum = n * (n + 1)/2";
            // 
            // labEquality
            // 
            this.labEquality.AutoSize = true;
            this.labEquality.Location = new System.Drawing.Point(230, 297);
            this.labEquality.Name = "labEquality";
            this.labEquality.Size = new System.Drawing.Size(0, 25);
            this.labEquality.TabIndex = 3;
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(276, 127);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(112, 34);
            this.compare.TabIndex = 4;
            this.compare.Text = "Compare";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // inpNumber
            // 
            this.inpNumber.Location = new System.Drawing.Point(414, 57);
            this.inpNumber.Name = "inpNumber";
            this.inpNumber.Size = new System.Drawing.Size(150, 31);
            this.inpNumber.TabIndex = 5;
            // 
            // labSum
            // 
            this.labSum.AutoSize = true;
            this.labSum.Location = new System.Drawing.Point(383, 195);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(0, 25);
            this.labSum.TabIndex = 6;
            // 
            // labMult
            // 
            this.labMult.AutoSize = true;
            this.labMult.Location = new System.Drawing.Point(383, 233);
            this.labMult.Name = "labMult";
            this.labMult.Size = new System.Drawing.Size(0, 25);
            this.labMult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 612);
            this.Controls.Add(this.labMult);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.inpNumber);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.labEquality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labEquality;
        private Button compare;
        private TextBox inpNumber;
        private Label labSum;
        private Label labMult;
    }
}