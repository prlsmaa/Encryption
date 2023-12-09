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
    public partial class VigenerCipherForm : Form
    {
        public VigenerCipherForm() {InitializeComponent(); }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void EncryptionButton_Click(object sender, EventArgs e)
        {//при нажатии на кнопку "Расшифровать" создается объект, который на вход получает сообщение и ключевое слово
         //и к нему применяется метод зашифровки
            var cipher = new VigenerCipher(textBox2.Text, textBox1.Text);
            textBox3.Text=cipher.Encrypt();
        }
        private void button1_Click(object sender, EventArgs e)
        {//при нажатии кнопки "Расшивровать" происходят аналогичные действия
            var cipher = new VigenerCipher(textBox6.Text,textBox5.Text);
            textBox4.Text = cipher.Decrypt();
        }
        private void VigenerCipherForm_Load(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
    }
}
