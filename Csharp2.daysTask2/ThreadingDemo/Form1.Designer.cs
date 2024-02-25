
namespace ThreadingDemo
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
            this.bttnProcess1 = new System.Windows.Forms.Button();
            this.bttnProcess2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnProcess1
            // 
            this.bttnProcess1.AccessibleName = "";
            this.bttnProcess1.Location = new System.Drawing.Point(114, 71);
            this.bttnProcess1.Name = "bttnProcess1";
            this.bttnProcess1.Size = new System.Drawing.Size(94, 29);
            this.bttnProcess1.TabIndex = 0;
            this.bttnProcess1.Text = "İşlem1";
            this.bttnProcess1.UseVisualStyleBackColor = true;
            this.bttnProcess1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnProcess2
            // 
            this.bttnProcess2.AccessibleName = "";
            this.bttnProcess2.Location = new System.Drawing.Point(361, 71);
            this.bttnProcess2.Name = "bttnProcess2";
            this.bttnProcess2.Size = new System.Drawing.Size(94, 29);
            this.bttnProcess2.TabIndex = 1;
            this.bttnProcess2.Text = "İşlem2";
            this.bttnProcess2.UseVisualStyleBackColor = true;
            this.bttnProcess2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnProcess2);
            this.Controls.Add(this.bttnProcess1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnProcess1;
        private System.Windows.Forms.Button bttnProcess2;
    }
}

