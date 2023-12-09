using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class RSA
    {
        private string Message { get; set; }
        public int P { get; set; }
        public int Q { get; set; }
        public int N { get; set; }
        private int Fi { get; set; }
        public int E { get; set; }
        public int D { get; set; }
        public int Length { get; set; }
        public int[] Cipher { get; set; }
        public RSA(string message, int p,int q)
        {
            //вычисление некоторых параметров
            P = p;
            Q = q;
            N = P * Q;
            Fi = (P - 1) * (Q - 1);
            E = SearchPrimeNumber(Fi);//функция поиска взаимно простого числа с фи
            D = SearchD(E, Fi);
            Message = message;
            Length = Message.Length;
            Cipher=new int[Length];
        }
        public string RSACipher()
        {
            for (var i = 0; i < Length; i++)
            {
                //при вычислении кода буквы его значение уменьшаем на 64 для простоты вычисления степени этого
                //числа
                Cipher[i] = (int)(Math.Pow((int)Message[i] - 64, E) % N);
            }
            return String.Join("",Cipher);
        }
        public string RSADecoding()
        {
            var decryptedText = new char[Length];
            for (var i = 0; i < Length; i++)
            {
                //т.к. на этапе шифровки мы вычитали 64 для удобства вычисления, то на этапе дешифровки мы 
                //прибавляем
                decryptedText[i] = (char)((Math.Pow(Cipher[i], D) % N) + 64);
            }
            return new string(decryptedText);
        }

        private int NOD(int a, int b)
        {
            if (a == b)
                return a;
            else
            if (a > b)
                return NOD(a - b, b);
            else
                return NOD(b - a, a);
        }

        private int SearchPrimeNumber(int a)
        {
            for (var i = 2; i < a; i++)
            {
                if (NOD(i, a) == 1) return i;
            }
            return 0;
        }

        private int SearchD(int e, int fi)
        {
            var d = 1;
            while (true)
            {
                if ((d * e) % fi == 1) return d;
                d++;
            }
        }
    }
}
