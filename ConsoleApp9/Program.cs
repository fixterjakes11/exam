using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        /// <summary>
        /// 1 билет
        /// </summary>
        public static void Tasck1()
        {
            string word = "first%second$three^fo*five";
            string signs = "%$^*";
            char[] sign = signs.ToCharArray();
            string[] words = word.Split(sign, StringSplitOptions.RemoveEmptyEntries);
            foreach (var s in words)
            {
                Console.WriteLine(s);
            }
        }


        /// <summary>
        /// 4 билет
        /// </summary>
        public static void Tasck4()
        {
            var s = Console.ReadLine();
            foreach (char ch in s)
            {
                Console.WriteLine($"Буква: {ch} = " + GetContentNumber(ch));
            }
        }
        public static int GetContentNumber(char letter)
        {
            var alph = new List<char>();

            for (char c = 'a'; c <= 'z'; c++)
            {
                alph.Add(c);
            }
            return alph.FindIndex(a => a.ToString() == letter.ToString().ToLower()) + 1;
        }




        /// <summary>
        /// 2 билет
        /// </summary>
        public static void Tasck2()
        {
            Console.WriteLine("Напишите строку: ");
            string s = Console.ReadLine();
            int count = 0;
            foreach (char ch in s)
            {
                if (Char.IsDigit(ch))
                    count++;

            }
            Console.WriteLine("Количесство цифр в строке: " + count);
        }




        /// <summary>
        /// 3 билет
        /// </summary>
        public static void Taskc3()
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            string res = Convert.ToString(Fofmula(a, b));
            Console.WriteLine("Result: " + res);
            string result = res.Substring(res.Length - 1);
            Console.WriteLine($"Последняя цифра: {result} ");

        }
        public static double Fofmula(double a, double b)
        {

            double pow = Math.Pow(a, b);
            return pow;
        }

        
    }
}
