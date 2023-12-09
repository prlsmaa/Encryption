using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class RSAForm : Form
    {
        public RSA Cipher { get; set; }
        public RSAForm() { InitializeComponent(); }
        private void RSAForm_Load(object sender, EventArgs e) { }
        private void MessageForEncryption_TextChanged(object sender, EventArgs e) { }
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Cipher = new RSA(MessageForEncryption.Text, int.Parse(textBox6.Text), int.Parse(textBox7.Text));
            textBox1.Text=Cipher.RSACipher();
            Key1.Text = Cipher.E.ToString();
            Key2.Text = Cipher.N.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Key1_TextChanged(object sender, EventArgs e) { }
        private void Key2_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = Cipher.RSADecoding();
            textBox4.Text = Cipher.D.ToString();
            textBox3.Text = Cipher.N.ToString();
        }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged_3(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e){ }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
    }
}
