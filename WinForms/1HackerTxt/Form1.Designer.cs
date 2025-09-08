using System.Windows.Forms;

namespace _1HackerTxt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnSkriv;
        private Button btnLäs;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSkriv = new System.Windows.Forms.Button();
            this.btnLäs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(30, 30);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 80);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(30, 180);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(300, 80);
            this.txtOutput.TabIndex = 1;
            // 
            // btnSkriv
            // 
            this.btnSkriv.Location = new System.Drawing.Point(350, 30);
            this.btnSkriv.Name = "btnSkriv";
            this.btnSkriv.Size = new System.Drawing.Size(100, 30);
            this.btnSkriv.TabIndex = 2;
            this.btnSkriv.Text = "Skriv";
            this.btnSkriv.UseVisualStyleBackColor = true;
            this.btnSkriv.Click += new System.EventHandler(this.btnSkriv_Click);
            // 
            // btnLäs
            // 
            this.btnLäs.Location = new System.Drawing.Point(350, 180);
            this.btnLäs.Name = "btnLäs";
            this.btnLäs.Size = new System.Drawing.Size(100, 30);
            this.btnLäs.TabIndex = 3;
            this.btnLäs.Text = "Läs";
            this.btnLäs.UseVisualStyleBackColor = true;
            this.btnLäs.Click += new System.EventHandler(this.btnLäs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.btnLäs);
            this.Controls.Add(this.btnSkriv);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "HackerTxt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
