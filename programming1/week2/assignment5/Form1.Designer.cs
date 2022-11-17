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
            this.calculate = new System.Windows.Forms.Button();
            this.labFirstNum = new System.Windows.Forms.Label();
            this.labSecondNum = new System.Windows.Forms.Label();
            this.labThirdNum = new System.Windows.Forms.Label();
            this.firstNum = new System.Windows.Forms.TextBox();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.thirdNum = new System.Windows.Forms.TextBox();
            this.labAvgNum = new System.Windows.Forms.Label();
            this.avgNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(200, 224);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(189, 34);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calculate average";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // labFirstNum
            // 
            this.labFirstNum.AutoSize = true;
            this.labFirstNum.Location = new System.Drawing.Point(73, 68);
            this.labFirstNum.Name = "labFirstNum";
            this.labFirstNum.Size = new System.Drawing.Size(96, 25);
            this.labFirstNum.TabIndex = 1;
            this.labFirstNum.Text = "Number 1:";
            // 
            // labSecondNum
            // 
            this.labSecondNum.AutoSize = true;
            this.labSecondNum.Location = new System.Drawing.Point(73, 118);
            this.labSecondNum.Name = "labSecondNum";
            this.labSecondNum.Size = new System.Drawing.Size(96, 25);
            this.labSecondNum.TabIndex = 2;
            this.labSecondNum.Text = "Number 2:";
            // 
            // labThirdNum
            // 
            this.labThirdNum.AutoSize = true;
            this.labThirdNum.Location = new System.Drawing.Point(73, 171);
            this.labThirdNum.Name = "labThirdNum";
            this.labThirdNum.Size = new System.Drawing.Size(96, 25);
            this.labThirdNum.TabIndex = 3;
            this.labThirdNum.Text = "Number 3:";
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(357, 68);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(150, 31);
            this.firstNum.TabIndex = 4;
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(357, 118);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(150, 31);
            this.secondNum.TabIndex = 5;
            // 
            // thirdNum
            // 
            this.thirdNum.Location = new System.Drawing.Point(357, 171);
            this.thirdNum.Name = "thirdNum";
            this.thirdNum.Size = new System.Drawing.Size(150, 31);
            this.thirdNum.TabIndex = 6;
            // 
            // labAvgNum
            // 
            this.labAvgNum.AutoSize = true;
            this.labAvgNum.Location = new System.Drawing.Point(73, 303);
            this.labAvgNum.Name = "labAvgNum";
            this.labAvgNum.Size = new System.Drawing.Size(77, 25);
            this.labAvgNum.TabIndex = 7;
            this.labAvgNum.Text = "Average";
            // 
            // avgNum
            // 
            this.avgNum.AutoSize = true;
            this.avgNum.Location = new System.Drawing.Point(256, 303);
            this.avgNum.Name = "avgNum";
            this.avgNum.Size = new System.Drawing.Size(17, 25);
            this.avgNum.TabIndex = 8;
            this.avgNum.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.avgNum);
            this.Controls.Add(this.labAvgNum);
            this.Controls.Add(this.thirdNum);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.labThirdNum);
            this.Controls.Add(this.labSecondNum);
            this.Controls.Add(this.labFirstNum);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculate;
        private Label labFirstNum;
        private Label labSecondNum;
        private Label labThirdNum;
        private TextBox firstNum;
        private TextBox secondNum;
        private TextBox thirdNum;
        private Label labAvgNum;
        private Label avgNum;
    }
}