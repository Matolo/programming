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
            this.labContentTableBefore = new System.Windows.Forms.Label();
            this.labContentTableAfter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpComparsionNumber = new System.Windows.Forms.TextBox();
            this.compare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labContentTableBefore
            // 
            this.labContentTableBefore.AutoSize = true;
            this.labContentTableBefore.Location = new System.Drawing.Point(40, 53);
            this.labContentTableBefore.Name = "labContentTableBefore";
            this.labContentTableBefore.Size = new System.Drawing.Size(0, 25);
            this.labContentTableBefore.TabIndex = 0;
            // 
            // labContentTableAfter
            // 
            this.labContentTableAfter.AutoSize = true;
            this.labContentTableAfter.Location = new System.Drawing.Point(507, 53);
            this.labContentTableAfter.Name = "labContentTableAfter";
            this.labContentTableAfter.Size = new System.Drawing.Size(0, 25);
            this.labContentTableAfter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Content table (before)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Content table (after)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 717);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comparsion number";
            // 
            // inpComparsionNumber
            // 
            this.inpComparsionNumber.Location = new System.Drawing.Point(277, 711);
            this.inpComparsionNumber.Name = "inpComparsionNumber";
            this.inpComparsionNumber.Size = new System.Drawing.Size(150, 31);
            this.inpComparsionNumber.TabIndex = 5;
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(507, 709);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(112, 34);
            this.compare.TabIndex = 6;
            this.compare.Text = "Compare";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 755);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.inpComparsionNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labContentTableAfter);
            this.Controls.Add(this.labContentTableBefore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labContentTableBefore;
        private Label labContentTableAfter;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inpComparsionNumber;
        private Button compare;
    }
}