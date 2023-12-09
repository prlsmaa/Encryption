using System;

namespace Encryption
{
    public class VigenerCipher
    {
        private char[] KeywordText { get; set; }//слово, которое содержит циклическое повторение ключевого слова
        //в соответвии с методом шифрования
        private char[] Key { get; set; }//ключевое слово
        private char[] Message { get; set; }//сообщение для шифрования
        private int Length;//длина зашифрованного или расшифрованного сообщения
        public VigenerCipher(string key, string message)
        {
            Message = message.ToCharArray();
            Length = message.Length;
            Key = key.ToCharArray();
            KeywordText = new char[Length];
            //создание слова, которое циклически повторяет ключевое слово, пока не достигнута длина сообщения,
            //которое необходимо зашифровать/расшифровать
            for (var i = 0; i < Length; i += 5)
            {
                for (var j = 0; j < Key.Length; j++)
                {
                    if (i + j == Length) break;
                    KeywordText[i + j] = Key[j];
                }
            }
        }
        public string Encrypt()
        {
            var cipher = new char[Length];
            for (var i = 0; i < Length; i++)
            {//согласно методу вычисляет код буквы из таблицы аски и запишем его, преобразуя при этом к символьному
             //типу, в строку зашифрованного сообщения
                var index = (Message[i] + KeywordText[i]) >155 ? 
                    Message[i] + KeywordText[i] - 91: 
                    Message[i] + KeywordText[i]-65;
                cipher[i] = (char)index;
            }
            return new string(cipher);
        }
        public string Decrypt()
        {
            var decryptedText = new char[Length];
            for (var i = 0; i < Length; i++)
            {//согласно методу вычисляет код буквы из таблицы аски
                var index = Math.Abs(Message[i]- KeywordText[i])+65;
                decryptedText[i] = (char)index;
            }
            return new string(decryptedText);
        }
    }
}
