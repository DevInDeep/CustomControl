namespace CustomControl
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
            this.gradientButton1 = new CustomControl.GradientButton();
            this.SuspendLayout();
            // 
            // gradientButton1
            // 
            this.gradientButton1.Location = new System.Drawing.Point(67, 71);
            this.gradientButton1.Margin = new System.Windows.Forms.Padding(1);
            this.gradientButton1.Name = "gradientButton1";
            this.gradientButton1.Size = new System.Drawing.Size(96, 33);
            this.gradientButton1.TabIndex = 0;
            this.gradientButton1.Text = "Button";
            this.gradientButton1.Click += new System.EventHandler(this.gradientButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.gradientButton1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientButton gradientButton1;
    }
}

