namespace frmVisaTextMeddelande
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdVisaMeddelande_Click(object sender, EventArgs e)
        {
            string meddelande = txtTextruta1.Text + " " + txtTextruta2.Text;
            MessageBox.Show(meddelande, "Ditt meddelande");
        }

        private void txtTextruta1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
