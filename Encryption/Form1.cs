using System;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PermutationEncryptionButton_Click(object sender, EventArgs e)
        {
            PermutationEncryptionForm newForm = new PermutationEncryptionForm();
            //this.Close();
            newForm.Show();
        }

        private void VigenerEncryptionButton_Click(object sender, EventArgs e)
        {
            VigenerCipherForm newForm = new VigenerCipherForm();
            newForm.Show();
        }

        private void RSAButton_Click(object sender, EventArgs e)
        {
            RSAForm newForm = new RSAForm();
            newForm.Show();
        }
    }
}