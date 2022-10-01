
namespace Cruel_Games
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
            this.rbnLess21 = new System.Windows.Forms.RadioButton();
            this.rbnMore35 = new System.Windows.Forms.RadioButton();
            this.rbn21to35 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbnLess21
            // 
            this.rbnLess21.AutoSize = true;
            this.rbnLess21.Location = new System.Drawing.Point(86, 68);
            this.rbnLess21.Name = "rbnLess21";
            this.rbnLess21.Size = new System.Drawing.Size(81, 21);
            this.rbnLess21.TabIndex = 0;
            this.rbnLess21.TabStop = true;
            this.rbnLess21.Text = "up to 21";
            this.rbnLess21.UseVisualStyleBackColor = true;
            this.rbnLess21.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbnMore35
            // 
            this.rbnMore35.AutoSize = true;
            this.rbnMore35.Location = new System.Drawing.Point(86, 146);
            this.rbnMore35.Name = "rbnMore35";
            this.rbnMore35.Size = new System.Drawing.Size(88, 21);
            this.rbnMore35.TabIndex = 1;
            this.rbnMore35.TabStop = true;
            this.rbnMore35.Text = "above 35";
            this.rbnMore35.UseVisualStyleBackColor = true;
            // 
            // rbn21to35
            // 
            this.rbn21to35.AutoSize = true;
            this.rbn21to35.Location = new System.Drawing.Point(86, 107);
            this.rbn21to35.Name = "rbn21to35";
            this.rbn21to35.Size = new System.Drawing.Size(81, 21);
            this.rbn21to35.TabIndex = 2;
            this.rbn21to35.TabStop = true;
            this.rbn21to35.Text = "21 to 35";
            this.rbn21to35.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbn21to35);
            this.Controls.Add(this.rbnMore35);
            this.Controls.Add(this.rbnLess21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnLess21;
        private System.Windows.Forms.RadioButton rbnMore35;
        private System.Windows.Forms.RadioButton rbn21to35;
        private System.Windows.Forms.Button button1;
    }
}

