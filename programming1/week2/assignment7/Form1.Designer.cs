namespace assignment7
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
            this.btnErase = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.inpStKm = new System.Windows.Forms.TextBox();
            this.inpEndKm = new System.Windows.Forms.TextBox();
            this.inpPriceKm = new System.Windows.Forms.TextBox();
            this.labPriceEVAT = new System.Windows.Forms.Label();
            this.labVAT = new System.Windows.Forms.Label();
            this.labPriceIVAT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "End km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price / km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price excl VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price incl VAT";
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(427, 60);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(112, 34);
            this.btnErase.TabIndex = 6;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.erase_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(427, 159);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 34);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // inpStKm
            // 
            this.inpStKm.Location = new System.Drawing.Point(234, 62);
            this.inpStKm.Name = "inpStKm";
            this.inpStKm.Size = new System.Drawing.Size(150, 31);
            this.inpStKm.TabIndex = 8;
            // 
            // inpEndKm
            // 
            this.inpEndKm.Location = new System.Drawing.Point(234, 110);
            this.inpEndKm.Name = "inpEndKm";
            this.inpEndKm.Size = new System.Drawing.Size(150, 31);
            this.inpEndKm.TabIndex = 9;
            // 
            // inpPriceKm
            // 
            this.inpPriceKm.Location = new System.Drawing.Point(234, 159);
            this.inpPriceKm.Name = "inpPriceKm";
            this.inpPriceKm.Size = new System.Drawing.Size(150, 31);
            this.inpPriceKm.TabIndex = 10;
            // 
            // labPriceEVAT
            // 
            this.labPriceEVAT.AutoSize = true;
            this.labPriceEVAT.Location = new System.Drawing.Point(53, 355);
            this.labPriceEVAT.Name = "labPriceEVAT";
            this.labPriceEVAT.Size = new System.Drawing.Size(17, 25);
            this.labPriceEVAT.TabIndex = 11;
            this.labPriceEVAT.Text = " ";
            // 
            // labVAT
            // 
            this.labVAT.AutoSize = true;
            this.labVAT.Location = new System.Drawing.Point(234, 355);
            this.labVAT.Name = "labVAT";
            this.labVAT.Size = new System.Drawing.Size(17, 25);
            this.labVAT.TabIndex = 12;
            this.labVAT.Text = " ";
            // 
            // labPriceIVAT
            // 
            this.labPriceIVAT.AutoSize = true;
            this.labPriceIVAT.Location = new System.Drawing.Point(458, 355);
            this.labPriceIVAT.Name = "labPriceIVAT";
            this.labPriceIVAT.Size = new System.Drawing.Size(17, 25);
            this.labPriceIVAT.TabIndex = 13;
            this.labPriceIVAT.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(38, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 1);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labPriceIVAT);
            this.Controls.Add(this.labVAT);
            this.Controls.Add(this.labPriceEVAT);
            this.Controls.Add(this.inpPriceKm);
            this.Controls.Add(this.inpEndKm);
            this.Controls.Add(this.inpStKm);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnErase;
        private Button btnCalculate;
        private TextBox inpStKm;
        private TextBox inpEndKm;
        private TextBox inpPriceKm;
        private Label labPriceEVAT;
        private Label labVAT;
        private Label labPriceIVAT;
        private Panel panel1;
    }
}