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
            this.inpNumber = new System.Windows.Forms.TextBox();
            this.squareByRef = new System.Windows.Forms.Button();
            this.squareByRefOut = new System.Windows.Forms.Button();
            this.squareByValue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // inpNumber
            // 
            this.inpNumber.Location = new System.Drawing.Point(269, 37);
            this.inpNumber.Name = "inpNumber";
            this.inpNumber.Size = new System.Drawing.Size(125, 27);
            this.inpNumber.TabIndex = 1;
            // 
            // squareByRef
            // 
            this.squareByRef.Location = new System.Drawing.Point(122, 135);
            this.squareByRef.Name = "squareByRef";
            this.squareByRef.Size = new System.Drawing.Size(237, 29);
            this.squareByRef.TabIndex = 2;
            this.squareByRef.Text = "Square by reference";
            this.squareByRef.UseVisualStyleBackColor = true;
            this.squareByRef.Click += new System.EventHandler(this.squareByRef_Click);
            // 
            // squareByRefOut
            // 
            this.squareByRefOut.Location = new System.Drawing.Point(122, 170);
            this.squareByRefOut.Name = "squareByRefOut";
            this.squareByRefOut.Size = new System.Drawing.Size(237, 29);
            this.squareByRefOut.TabIndex = 3;
            this.squareByRefOut.Text = "Square by reference out";
            this.squareByRefOut.UseVisualStyleBackColor = true;
            this.squareByRefOut.Click += new System.EventHandler(this.squareByRefOut_Click);
            // 
            // squareByValue
            // 
            this.squareByValue.Location = new System.Drawing.Point(122, 205);
            this.squareByValue.Name = "squareByValue";
            this.squareByValue.Size = new System.Drawing.Size(237, 29);
            this.squareByValue.TabIndex = 4;
            this.squareByValue.Text = "Square by value";
            this.squareByValue.UseVisualStyleBackColor = true;
            this.squareByValue.Click += new System.EventHandler(this.squareByValue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(269, 304);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(0, 20);
            this.labResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 387);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.squareByValue);
            this.Controls.Add(this.squareByRefOut);
            this.Controls.Add(this.squareByRef);
            this.Controls.Add(this.inpNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inpNumber;
        private Button squareByRef;
        private Button squareByRefOut;
        private Button squareByValue;
        private Label label2;
        private Label labResult;
    }
}