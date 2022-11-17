namespace assignment6
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
            this.labFinalCap = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.inputCapital = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final capital";
            // 
            // labFinalCap
            // 
            this.labFinalCap.AutoSize = true;
            this.labFinalCap.Location = new System.Drawing.Point(324, 262);
            this.labFinalCap.Name = "labFinalCap";
            this.labFinalCap.Size = new System.Drawing.Size(0, 25);
            this.labFinalCap.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(148, 185);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(220, 34);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate final capital";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // inputCapital
            // 
            this.inputCapital.Location = new System.Drawing.Point(315, 58);
            this.inputCapital.Name = "inputCapital";
            this.inputCapital.Size = new System.Drawing.Size(150, 31);
            this.inputCapital.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 330);
            this.Controls.Add(this.inputCapital);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.labFinalCap);
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
        private Label labFinalCap;
        private Button calculate;
        private TextBox inputCapital;
    }
}