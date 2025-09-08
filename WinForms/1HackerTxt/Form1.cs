using System;
using System.IO;
using System.Windows.Forms;

namespace _1HackerTxt
{
    public partial class Form1 : Form
    {
        string filnamn = @"C:\Temp\Testfil.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkriv_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filnamn)!); // se till att mappen finns

                using (var writer = new StreamWriter(filnamn, false))
                {
                    writer.WriteLine("I am a C# hacker");
                    writer.WriteLine(txtInput.Text);
                }
                MessageBox.Show("Text sparad till fil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte spara: {ex.Message}");
            }
        }

        private void btnLäs_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filnamn))
                {
                    txtOutput.Text = File.ReadAllText(filnamn);
                }
                else
                {
                    MessageBox.Show("Filen finns inte ännu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte läsa: {ex.Message}");
            }
        }
    }
}
