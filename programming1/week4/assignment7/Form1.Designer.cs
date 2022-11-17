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
            this.inpSides = new System.Windows.Forms.TextBox();
            this.createSquares = new System.Windows.Forms.Button();
            this.labSquare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side";
            // 
            // inpSides
            // 
            this.inpSides.Location = new System.Drawing.Point(367, 55);
            this.inpSides.Name = "inpSides";
            this.inpSides.Size = new System.Drawing.Size(150, 31);
            this.inpSides.TabIndex = 1;
            // 
            // createSquares
            // 
            this.createSquares.Location = new System.Drawing.Point(177, 132);
            this.createSquares.Name = "createSquares";
            this.createSquares.Size = new System.Drawing.Size(185, 34);
            this.createSquares.TabIndex = 2;
            this.createSquares.Text = "Create square";
            this.createSquares.UseVisualStyleBackColor = true;
            this.createSquares.Click += new System.EventHandler(this.createSquares_Click);
            // 
            // labSquare
            // 
            this.labSquare.AutoSize = true;
            this.labSquare.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSquare.Location = new System.Drawing.Point(177, 257);
            this.labSquare.Name = "labSquare";
            this.labSquare.Size = new System.Drawing.Size(0, 31);
            this.labSquare.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 1022);
            this.Controls.Add(this.labSquare);
            this.Controls.Add(this.createSquares);
            this.Controls.Add(this.inpSides);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inpSides;
        private Button createSquares;
        private Label labSquare;
    }
}