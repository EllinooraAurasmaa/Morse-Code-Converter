namespace Morse_Code_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 36);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(109, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Please enter a string: ";
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(127, 36);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(100, 20);
            this.textBoxString.TabIndex = 1;
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutput.Location = new System.Drawing.Point(127, 69);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(100, 23);
            this.labelOutput.TabIndex = 2;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(51, 74);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(70, 13);
            this.labelCode.TabIndex = 3;
            this.labelCode.Text = "Morse Code: ";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(45, 121);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(86, 39);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(137, 121);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 39);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 170);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Morse Code Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonExit;
    }
}

