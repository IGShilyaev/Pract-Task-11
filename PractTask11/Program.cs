using System;

namespace PractTask11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = "";
            for (int i = 0; i < 121; i++)
            {
                if (i % 3 == 0) text += "A";
                else if (i % 3 == 1) text += "B";
                else text += "C";
            }
            Console.WriteLine("Незашифрованный текст:");
            Console.WriteLine(text);

            string ciphText = CiphText(text);

            Console.WriteLine("Зашифрованный текст:");
            Console.WriteLine(ciphText);

            string deCiphText = DeCiphText(ciphText);

            Console.WriteLine("Расшифрованный текст:");
            Console.WriteLine(deCiphText);
        }

        public static char[,] CreateCiphTable(string text)
        {
            if (text.Length != 121) { return null; }
            int index = 0;
            char[,] codeArr = new char[11, 11];
            for (int i = 0; i < codeArr.GetLength(0); i++)
            {
                for (int j = 0; j < codeArr.GetLength(1); j++)
                {
                    codeArr[i, j] = text[index];
                    index++;
                }
            }
            return codeArr;
        }

        public static string CiphText(string text)
        {
            char[,] codeArr = CreateCiphTable(text);
            if (text.Length!=121||codeArr==null||codeArr.Length!=121)
            {
                Console.WriteLine("Ошибка входных данных!");
                return "";
            }

            string ciphText = "";
            int iIndex = codeArr.GetLength(0) / 2;
            int jIndex = codeArr.GetLength(0) / 2;
            int iStep = 1;
            int jStep = 1;

            ciphText += codeArr[iIndex, jIndex];
            for (int i = 0; i < 11; i++)
            {
                for (int hor = 0; hor < i; hor++) { jIndex += jStep; ciphText += codeArr[iIndex, jIndex]; }
                for (int vert = 0; vert < i; vert++) { iIndex += iStep; ciphText += codeArr[iIndex, jIndex]; }
                jStep = -jStep;
                iStep = -iStep;
            }
            for (int hor = 0; hor < codeArr.GetLength(0) - 1; hor++)
            {
                jIndex += jStep;
                ciphText += codeArr[iIndex, jIndex];
            }

            return ciphText;
        }

        public static char[,] CreateDeciphTable(string text)
        {
            if (text.Length != 121) { return null; }
            char[,] codeArr = new char[11, 11]; 

            int iIndex = codeArr.GetLength(0) / 2;
            int jIndex = codeArr.GetLength(0) / 2;
            int iStep = 1;
            int jStep = 1;

            codeArr[iIndex, jIndex] = text[0];
            int index = 0; 
            for (int i = 0; i < 11; i++)
            {
                for (int hor = 0; hor < i; hor++) { jIndex += jStep; index++; codeArr[iIndex, jIndex] = text[index]; }
                for (int vert = 0; vert < i; vert++) { iIndex += iStep; index++; codeArr[iIndex, jIndex] = text[index]; }
                jStep = -jStep;
                iStep = -iStep;
            }
            for (int hor = 0; hor < codeArr.GetLength(0) - 1; hor++)
            {
                jIndex += jStep;
                index++;
                codeArr[iIndex, jIndex] = text[index];
            }
            return codeArr;
        }

        public static string DeCiphText(string text)
        {
            char[,] deciphArr = CreateDeciphTable(text);
            if (text.Length != 121 || deciphArr == null || deciphArr.Length != 121)
            {
                Console.WriteLine("Ошибка входных данных!");
                return "";
            }

            string deciphedText = "";

            for (int i = 0; i < deciphArr.GetLength(0); i++)
            {
                for (int j = 0; j < deciphArr.GetLength(1); j++)
                {
                    deciphedText += deciphArr[i, j];
                }
            }
            return deciphedText;
        }

    }
}
