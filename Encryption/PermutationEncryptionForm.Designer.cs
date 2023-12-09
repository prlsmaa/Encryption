using System.Windows.Forms;

namespace Encryption
{
    partial class PermutationEncryptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageForEncryption = new System.Windows.Forms.TextBox();
            this.Key1 = new System.Windows.Forms.TextBox();
            this.Key2 = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EncryptedMessage = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageForEncryption
            // 
            this.MessageForEncryption.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MessageForEncryption.Location = new System.Drawing.Point(22, 43);
            this.MessageForEncryption.Name = "MessageForEncryption";
            this.MessageForEncryption.Size = new System.Drawing.Size(243, 23);
            this.MessageForEncryption.TabIndex = 0;
            this.MessageForEncryption.TextChanged += new System.EventHandler(this.MessageForEncryption_TextChanged);
            // 
            // Key1
            // 
            this.Key1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Key1.Location = new System.Drawing.Point(22, 104);
            this.Key1.Name = "Key1";
            this.Key1.Size = new System.Drawing.Size(243, 23);
            this.Key1.TabIndex = 1;
            this.Key1.TextChanged += new System.EventHandler(this.Key1_TextChanged);
            // 
            // Key2
            // 
            this.Key2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Key2.Location = new System.Drawing.Point(22, 164);
            this.Key2.Name = "Key2";
            this.Key2.Size = new System.Drawing.Size(243, 23);
            this.Key2.TabIndex = 2;
            this.Key2.TextChanged += new System.EventHandler(this.Key2_TextChanged);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Message.Location = new System.Drawing.Point(22, 19);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(220, 21);
            this.Message.TabIndex = 3;
            this.Message.Text = "Сообщение для шифрования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ключ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ключ 2";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EncryptButton.Location = new System.Drawing.Point(23, 201);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(159, 29);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Зашифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(22, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(243, 23);
            this.textBox1.TabIndex = 7;
            // 
            // EncryptedMessage
            // 
            this.EncryptedMessage.AutoSize = true;
            this.EncryptedMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EncryptedMessage.Location = new System.Drawing.Point(22, 249);
            this.EncryptedMessage.Name = "EncryptedMessage";
            this.EncryptedMessage.Size = new System.Drawing.Size(214, 21);
            this.EncryptedMessage.TabIndex = 8;
            this.EncryptedMessage.Text = "Зашифрованное сообщение";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecryptButton.Location = new System.Drawing.Point(22, 312);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(159, 29);
            this.DecryptButton.TabIndex = 9;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Расшифрованное сообщение";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(22, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(243, 23);
            this.textBox2.TabIndex = 10;
            // 
            // PermutationEncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptedMessage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Key2);
            this.Controls.Add(this.Key1);
            this.Controls.Add(this.MessageForEncryption);
            this.Name = "PermutationEncryptionForm";
            this.Text = "Шифрование перестановкой";
            this.Load += new System.EventHandler(this.PermutationEncryptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox MessageForEncryption;
        private TextBox Key1;
        private TextBox Key2;
        private Label Message;
        private Label label1;
        private Label label2;
        private Button EncryptButton;
        private TextBox textBox1;
        private Label EncryptedMessage;
        private Button DecryptButton;
        private Label label3;
        private TextBox textBox2;
    }
}