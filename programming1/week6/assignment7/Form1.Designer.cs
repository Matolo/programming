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
            this.labResult = new System.Windows.Forms.Label();
            this.inpDegrees = new System.Windows.Forms.TextBox();
            this.rbtnCelsiusToKelvin = new System.Windows.Forms.RadioButton();
            this.rbtnCelsiusToFarenheit = new System.Windows.Forms.RadioButton();
            this.rbtnFarenheitToCelsius = new System.Windows.Forms.RadioButton();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Converted Degrees";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(259, 365);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(0, 20);
            this.labResult.TabIndex = 2;
            // 
            // inpDegrees
            // 
            this.inpDegrees.Location = new System.Drawing.Point(304, 63);
            this.inpDegrees.Name = "inpDegrees";
            this.inpDegrees.Size = new System.Drawing.Size(125, 27);
            this.inpDegrees.TabIndex = 3;
            // 
            // rbtnCelsiusToKelvin
            // 
            this.rbtnCelsiusToKelvin.AutoSize = true;
            this.rbtnCelsiusToKelvin.Location = new System.Drawing.Point(120, 145);
            this.rbtnCelsiusToKelvin.Name = "rbtnCelsiusToKelvin";
            this.rbtnCelsiusToKelvin.Size = new System.Drawing.Size(139, 24);
            this.rbtnCelsiusToKelvin.TabIndex = 4;
            this.rbtnCelsiusToKelvin.TabStop = true;
            this.rbtnCelsiusToKelvin.Text = "Celsius To Kelvin";
            this.rbtnCelsiusToKelvin.UseVisualStyleBackColor = true;
            // 
            // rbtnCelsiusToFarenheit
            // 
            this.rbtnCelsiusToFarenheit.AutoSize = true;
            this.rbtnCelsiusToFarenheit.Location = new System.Drawing.Point(120, 175);
            this.rbtnCelsiusToFarenheit.Name = "rbtnCelsiusToFarenheit";
            this.rbtnCelsiusToFarenheit.Size = new System.Drawing.Size(159, 24);
            this.rbtnCelsiusToFarenheit.TabIndex = 5;
            this.rbtnCelsiusToFarenheit.TabStop = true;
            this.rbtnCelsiusToFarenheit.Text = "Celsius To Farenheit";
            this.rbtnCelsiusToFarenheit.UseVisualStyleBackColor = true;
            // 
            // rbtnFarenheitToCelsius
            // 
            this.rbtnFarenheitToCelsius.AutoSize = true;
            this.rbtnFarenheitToCelsius.Location = new System.Drawing.Point(120, 205);
            this.rbtnFarenheitToCelsius.Name = "rbtnFarenheitToCelsius";
            this.rbtnFarenheitToCelsius.Size = new System.Drawing.Size(159, 24);
            this.rbtnFarenheitToCelsius.TabIndex = 6;
            this.rbtnFarenheitToCelsius.TabStop = true;
            this.rbtnFarenheitToCelsius.Text = "Farenheit To Celsius";
            this.rbtnFarenheitToCelsius.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(60, 277);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(369, 52);
            this.Calculate.TabIndex = 7;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.rbtnFarenheitToCelsius);
            this.Controls.Add(this.rbtnCelsiusToFarenheit);
            this.Controls.Add(this.rbtnCelsiusToKelvin);
            this.Controls.Add(this.inpDegrees);
            this.Controls.Add(this.labResult);
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
        private Label labResult;
        private TextBox inpDegrees;
        private RadioButton rbtnCelsiusToKelvin;
        private RadioButton rbtnCelsiusToFarenheit;
        private RadioButton rbtnFarenheitToCelsius;
        private Button Calculate;
    }
}