namespace assignment5
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
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.inpNum1 = new System.Windows.Forms.TextBox();
            this.inpNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(87, 207);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(69, 59);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(177, 207);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(72, 59);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(265, 207);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(73, 59);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(356, 207);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(73, 59);
            this.divide.TabIndex = 3;
            this.divide.Text = ":";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(288, 349);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(0, 20);
            this.labResult.TabIndex = 7;
            // 
            // inpNum1
            // 
            this.inpNum1.Location = new System.Drawing.Point(315, 58);
            this.inpNum1.Name = "inpNum1";
            this.inpNum1.Size = new System.Drawing.Size(125, 27);
            this.inpNum1.TabIndex = 8;
            // 
            // inpNum2
            // 
            this.inpNum2.Location = new System.Drawing.Point(315, 94);
            this.inpNum2.Name = "inpNum2";
            this.inpNum2.Size = new System.Drawing.Size(125, 27);
            this.inpNum2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.inpNum2);
            this.Controls.Add(this.inpNum1);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button plus;
        private Button minus;
        private Button multiply;
        private Button divide;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labResult;
        private TextBox inpNum1;
        private TextBox inpNum2;
    }
}