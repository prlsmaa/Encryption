using System;
using System.Windows.Forms;

namespace Encryption
{
    public partial class PermutationEncryptionForm : Form
    {
        public PermutationEncryptionForm() { InitializeComponent(); }
        private void PermutationEncryptionForm_Load(object sender, EventArgs e) { }
        private void MessageForEncryption_TextChanged(object sender, EventArgs e) { }
        private void Key1_TextChanged(object sender, EventArgs e) { }
        private void Key2_TextChanged(object sender, EventArgs e) { }
        private void EncryptButton_Click(object sender, EventArgs e)
        {//при нажатии на кнопку "зашифровать" создается обьект класса с введенными в полях сообщения и двух
            //ключей значениями и к этому объекту применяется метод шифрования с помощью метода перестановки
            PermutationEncryption encryption = new PermutationEncryption
                (MessageForEncryption.Text, Key1.Text, Key2.Text);
            textBox1.Text = encryption.Permutation();
        }
        private void DecryptButton_Click(object sender, EventArgs e)
        {//аналогичные действия происходят при нажатии на кнопку "расшифровать". Единственным отличием является
            //то, что значение сообщения меняется на сообщение в строке "Зашифрованное сообщение"
            PermutationEncryption encryption = new PermutationEncryption
                (textBox1.Text, Key1.Text, Key2.Text);
            textBox2.Text = encryption.PermutationRev();
        }
    }
}
