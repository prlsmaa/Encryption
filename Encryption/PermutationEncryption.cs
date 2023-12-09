using System.Linq;

namespace Encryption
{
    public class PermutationEncryption
    {
        public char[] Text { get; set; }//сообщение для шифровки/расшифровки
        public int[] Key1 { get; set; }
        public int[] Key2 { get; set; }
        public PermutationEncryption(string text, string key1, string key2)
        {
            //перевод сообщения из стринг в массив букв
            Text = text.ToCharArray();;
            //перевод ключа из стринг в массив цифр
            Key1 = key1.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
            Key2 = key2.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
        }

        public  string Permutation()//зашифровка
        {
            var decryption = new char[Text.Length];
            var decryptionMatrix = new char[5, 5];//матрица в которую закосятся в том или инм порядке
            //буквы
            for (var i = 0; i < 5; i ++ )
            {
                for (var j = 0; j <  5; j++)
                {//заносим в матрицу построчно буквы в порядке к1 из каждой "пятерки" букв в исходном сообщении
                    decryptionMatrix[i, j] = Text[i*5 + Key1[j] - 1];
                }
                
            }
            for (var i = 0; i < 5; i ++ )
            {
                for (var j = 0; j < 5; j++)
                {//для получения зашифрованного сообщения считываем из матрицы столбцы в корядке к2
                    decryption[i*5 + j] = decryptionMatrix[ j, Key2[i] - 1];
                }
            }
            return new string(decryption);
        }
        public string PermutationRev()//расшифровка
        {
            var decryption = new char[Text.Length];
            var decryptionMatrix = new char[5, 5];
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {//считываем из зашифрованного текста "пятерки" букв в строки матрицы в порядке к2
                    decryptionMatrix[Key2[i] - 1, j] = Text[i * 5 + j];
                }
                
            }

            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {//считываем из матрицы столбцы в порядке к1
                    decryption[i * 5 + j] = decryptionMatrix[Key1[j] - 1, i];
                }
            }
            return new string(decryption);
        }
    }
}
