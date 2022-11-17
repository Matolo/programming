namespace assignment10
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
            this.labPrice = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.inpAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price ticket";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(293, 257);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(0, 25);
            this.labPrice.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(41, 176);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(329, 66);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate Price";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // inpAge
            // 
            this.inpAge.Location = new System.Drawing.Point(220, 70);
            this.inpAge.Name = "inpAge";
            this.inpAge.Size = new System.Drawing.Size(150, 31);
            this.inpAge.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 310);
            this.Controls.Add(this.inpAge);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.labPrice);
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
        private Label labPrice;
        private Button calculate;
        private TextBox inpAge;
    }
}