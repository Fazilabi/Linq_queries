namespace Diags02
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
            this.Result = new System.Windows.Forms.TextBox();
            this.Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 12);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(396, 261);
            this.Result.TabIndex = 0;
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(211, 279);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(197, 36);
            this.Click.TabIndex = 1;
            this.Click.Text = "Click";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 376);
            this.Controls.Add(this.Click);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Click;
    }
}

