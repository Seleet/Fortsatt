namespace frmVisaTextMeddelande
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
            txtTextruta2 = new TextBox();
            txtTextruta1 = new TextBox();
            cmdVisaMeddelande = new Button();
            SuspendLayout();
            // 
            // txtTextruta2
            // 
            txtTextruta2.Location = new Point(281, 182);
            txtTextruta2.Name = "txtTextruta2";
            txtTextruta2.Size = new Size(100, 23);
            txtTextruta2.TabIndex = 0;
            // 
            // txtTextruta1
            // 
            txtTextruta1.Location = new Point(157, 182);
            txtTextruta1.Name = "txtTextruta1";
            txtTextruta1.Size = new Size(100, 23);
            txtTextruta1.TabIndex = 1;
            txtTextruta1.Text = "ka";
            txtTextruta1.TextChanged += txtTextruta1_TextChanged;
            // 
            // cmdVisaMeddelande
            // 
            cmdVisaMeddelande.Location = new Point(421, 182);
            cmdVisaMeddelande.Name = "cmdVisaMeddelande";
            cmdVisaMeddelande.Size = new Size(75, 23);
            cmdVisaMeddelande.TabIndex = 2;
            cmdVisaMeddelande.Text = "Visa";
            cmdVisaMeddelande.UseVisualStyleBackColor = true;
            cmdVisaMeddelande.Click += cmdVisaMeddelande_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdVisaMeddelande);
            Controls.Add(txtTextruta1);
            Controls.Add(txtTextruta2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTextruta2;
        private TextBox txtTextruta1;
        private Button cmdVisaMeddelande;
    }
}
