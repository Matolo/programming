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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.calculate = new System.Windows.Forms.Button();
            this.inpNumOfTsh = new System.Windows.Forms.TextBox();
            this.inpNumOfJea = new System.Windows.Forms.TextBox();
            this.labDate = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labVAT = new System.Windows.Forms.Label();
            this.labTotPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of T-shirts (x € 30.00):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of jeans (x € 100.00):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "VAT: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Invoice";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(168, 177);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(323, 48);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // inpNumOfTsh
            // 
            this.inpNumOfTsh.Location = new System.Drawing.Point(407, 37);
            this.inpNumOfTsh.Name = "inpNumOfTsh";
            this.inpNumOfTsh.Size = new System.Drawing.Size(150, 31);
            this.inpNumOfTsh.TabIndex = 8;
            // 
            // inpNumOfJea
            // 
            this.inpNumOfJea.Location = new System.Drawing.Point(407, 103);
            this.inpNumOfJea.Name = "inpNumOfJea";
            this.inpNumOfJea.Size = new System.Drawing.Size(150, 31);
            this.inpNumOfJea.TabIndex = 9;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(255, 23);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(17, 25);
            this.labDate.TabIndex = 10;
            this.labDate.Text = " ";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(246, 48);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(17, 25);
            this.labPrice.TabIndex = 11;
            this.labPrice.Text = " ";
            // 
            // labVAT
            // 
            this.labVAT.AutoSize = true;
            this.labVAT.Location = new System.Drawing.Point(246, 73);
            this.labVAT.Name = "labVAT";
            this.labVAT.Size = new System.Drawing.Size(0, 25);
            this.labVAT.TabIndex = 12;
            // 
            // labTotPrice
            // 
            this.labTotPrice.AutoSize = true;
            this.labTotPrice.Location = new System.Drawing.Point(246, 110);
            this.labTotPrice.Name = "labTotPrice";
            this.labTotPrice.Size = new System.Drawing.Size(0, 25);
            this.labTotPrice.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labTotPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labVAT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labPrice);
            this.panel1.Controls.Add(this.labDate);
            this.panel1.Location = new System.Drawing.Point(115, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 187);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 475);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inpNumOfJea);
            this.Controls.Add(this.inpNumOfTsh);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button calculate;
        private TextBox inpNumOfTsh;
        private TextBox inpNumOfJea;
        private Label labDate;
        private Label labPrice;
        private Label labVAT;
        private Label labTotPrice;
        private Panel panel1;
    }
}