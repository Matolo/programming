namespace assignment4
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
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.enterPrice = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.vat = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.priceResult = new System.Windows.Forms.Label();
            this.vatResult = new System.Windows.Forms.Label();
            this.totalResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(146, 119);
            this.calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(130, 20);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Determine VAT";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(264, 34);
            this.inputPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(106, 23);
            this.inputPrice.TabIndex = 1;
            // 
            // enterPrice
            // 
            this.enterPrice.AutoSize = true;
            this.enterPrice.Location = new System.Drawing.Point(38, 35);
            this.enterPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterPrice.Name = "enterPrice";
            this.enterPrice.Size = new System.Drawing.Size(78, 15);
            this.enterPrice.TabIndex = 3;
            this.enterPrice.Text = "Enter a price: ";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(38, 148);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(36, 15);
            this.price.TabIndex = 4;
            this.price.Text = "Price:";
            // 
            // vat
            // 
            this.vat.AutoSize = true;
            this.vat.Location = new System.Drawing.Point(38, 179);
            this.vat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(29, 15);
            this.vat.TabIndex = 6;
            this.vat.Text = "VAT:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(38, 209);
            this.total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(38, 15);
            this.total.TabIndex = 8;
            this.total.Text = "Total: ";
            // 
            // priceResult
            // 
            this.priceResult.AutoSize = true;
            this.priceResult.Location = new System.Drawing.Point(264, 148);
            this.priceResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceResult.Name = "priceResult";
            this.priceResult.Size = new System.Drawing.Size(25, 15);
            this.priceResult.TabIndex = 9;
            this.priceResult.Text = "000";
            // 
            // vatResult
            // 
            this.vatResult.AutoSize = true;
            this.vatResult.Location = new System.Drawing.Point(264, 179);
            this.vatResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vatResult.Name = "vatResult";
            this.vatResult.Size = new System.Drawing.Size(25, 15);
            this.vatResult.TabIndex = 10;
            this.vatResult.Text = "000";
            // 
            // totalResult
            // 
            this.totalResult.AutoSize = true;
            this.totalResult.Location = new System.Drawing.Point(264, 209);
            this.totalResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalResult.Name = "totalResult";
            this.totalResult.Size = new System.Drawing.Size(25, 15);
            this.totalResult.TabIndex = 11;
            this.totalResult.Text = "000";
            this.totalResult.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 270);
            this.Controls.Add(this.totalResult);
            this.Controls.Add(this.vatResult);
            this.Controls.Add(this.priceResult);
            this.Controls.Add(this.total);
            this.Controls.Add(this.vat);
            this.Controls.Add(this.price);
            this.Controls.Add(this.enterPrice);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.calculate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = " Week 2 - Assignment 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculate;
        private TextBox inputPrice;
        private Label enterPrice;
        private Label price;
        private Label vat;
        private Label total;
        private Label priceResult;
        private Label vatResult;
        private Label totalResult;
    }
}