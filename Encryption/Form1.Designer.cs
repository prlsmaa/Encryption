using System.Windows.Forms;

namespace Encryption
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
            this.PermutationEncryptionButton = new System.Windows.Forms.Button();
            this.VigenerEncryptionButton = new System.Windows.Forms.Button();
            this.RSAButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PermutationEncryptionButton
            // 
            this.PermutationEncryptionButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PermutationEncryptionButton.Location = new System.Drawing.Point(84, 91);
            this.PermutationEncryptionButton.Name = "PermutationEncryptionButton";
            this.PermutationEncryptionButton.Size = new System.Drawing.Size(181, 73);
            this.PermutationEncryptionButton.TabIndex = 0;
            this.PermutationEncryptionButton.Text = "Шифрование перестановкой";
            this.PermutationEncryptionButton.UseVisualStyleBackColor = true;
            this.PermutationEncryptionButton.Click += new System.EventHandler(this.PermutationEncryptionButton_Click);
            // 
            // VigenerEncryptionButton
            // 
            this.VigenerEncryptionButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VigenerEncryptionButton.Location = new System.Drawing.Point(84, 170);
            this.VigenerEncryptionButton.Name = "VigenerEncryptionButton";
            this.VigenerEncryptionButton.Size = new System.Drawing.Size(181, 73);
            this.VigenerEncryptionButton.TabIndex = 1;
            this.VigenerEncryptionButton.Text = "Шифрование Виженера";
            this.VigenerEncryptionButton.UseVisualStyleBackColor = true;
            this.VigenerEncryptionButton.Click += new System.EventHandler(this.VigenerEncryptionButton_Click);
            // 
            // RSAButton
            // 
            this.RSAButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RSAButton.Location = new System.Drawing.Point(84, 249);
            this.RSAButton.Name = "RSAButton";
            this.RSAButton.Size = new System.Drawing.Size(181, 73);
            this.RSAButton.TabIndex = 2;
            this.RSAButton.Text = "RSA";
            this.RSAButton.UseVisualStyleBackColor = true;
            this.RSAButton.Click += new System.EventHandler(this.RSAButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите шифрование";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RSAButton);
            this.Controls.Add(this.VigenerEncryptionButton);
            this.Controls.Add(this.PermutationEncryptionButton);
            this.Name = "Form1";
            this.Text = "Шифровальщик";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PermutationEncryptionButton;
        private Button VigenerEncryptionButton;
        private Button RSAButton;
        private Label label1;
    }
}