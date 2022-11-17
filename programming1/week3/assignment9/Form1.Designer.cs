namespace assignment9
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
            this.inpAge = new System.Windows.Forms.TextBox();
            this.inpMemDur = new System.Windows.Forms.TextBox();
            this.rBtnFootball = new System.Windows.Forms.RadioButton();
            this.rBtnHandball = new System.Windows.Forms.RadioButton();
            this.calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labFeeToPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Membership duration";
            // 
            // inpAge
            // 
            this.inpAge.Location = new System.Drawing.Point(356, 196);
            this.inpAge.Name = "inpAge";
            this.inpAge.Size = new System.Drawing.Size(150, 31);
            this.inpAge.TabIndex = 3;
            // 
            // inpMemDur
            // 
            this.inpMemDur.Location = new System.Drawing.Point(356, 241);
            this.inpMemDur.Name = "inpMemDur";
            this.inpMemDur.Size = new System.Drawing.Size(150, 31);
            this.inpMemDur.TabIndex = 4;
            // 
            // rBtnFootball
            // 
            this.rBtnFootball.AutoSize = true;
            this.rBtnFootball.Location = new System.Drawing.Point(372, 67);
            this.rBtnFootball.Name = "rBtnFootball";
            this.rBtnFootball.Size = new System.Drawing.Size(102, 29);
            this.rBtnFootball.TabIndex = 5;
            this.rBtnFootball.TabStop = true;
            this.rBtnFootball.Text = "Football";
            this.rBtnFootball.UseVisualStyleBackColor = true;
            
            // 
            // rBtnHandball
            // 
            this.rBtnHandball.AutoSize = true;
            this.rBtnHandball.Location = new System.Drawing.Point(372, 111);
            this.rBtnHandball.Name = "rBtnHandball";
            this.rBtnHandball.Size = new System.Drawing.Size(108, 29);
            this.rBtnHandball.TabIndex = 6;
            this.rBtnHandball.TabStop = true;
            this.rBtnHandball.Text = "Handball";
            this.rBtnHandball.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(36, 303);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(470, 78);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate Fee";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fee to be paid";
            // 
            // labFeeToPay
            // 
            this.labFeeToPay.AutoSize = true;
            this.labFeeToPay.Location = new System.Drawing.Point(348, 403);
            this.labFeeToPay.Name = "labFeeToPay";
            this.labFeeToPay.Size = new System.Drawing.Size(0, 25);
            this.labFeeToPay.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.labFeeToPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.rBtnHandball);
            this.Controls.Add(this.rBtnFootball);
            this.Controls.Add(this.inpMemDur);
            this.Controls.Add(this.inpAge);
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
        private TextBox inpAge;
        private TextBox inpMemDur;
        private RadioButton rBtnFootball;
        private RadioButton rBtnHandball;
        private Button calculate;
        private Label label4;
        private Label labFeeToPay;
    }
}