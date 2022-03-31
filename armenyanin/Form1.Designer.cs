
namespace armenyanin
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
            this.kazakh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.da = new System.Windows.Forms.RichTextBox();
            this.papich = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // kazakh
            // 
            this.kazakh.Location = new System.Drawing.Point(34, 12);
            this.kazakh.Name = "kazakh";
            this.kazakh.Size = new System.Drawing.Size(100, 23);
            this.kazakh.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.da.Location = new System.Drawing.Point(12, 84);
            this.da.Name = "richTextBox1";
            this.da.Size = new System.Drawing.Size(184, 131);
            this.da.TabIndex = 2;
            this.da.Text = "";
            // 
            // richTextBox2
            // 
            this.papich.Location = new System.Drawing.Point(202, 84);
            this.papich.Name = "richTextBox2";
            this.papich.Size = new System.Drawing.Size(169, 131);
            this.papich.TabIndex = 3;
            this.papich.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.papich);
            this.Controls.Add(this.da);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kazakh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kazakh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox da;
        private System.Windows.Forms.RichTextBox papich;
    }
}

