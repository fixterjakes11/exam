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
        /// 5 билет
        /// </summary>
        public static void Tack5()
        {
            Console.WriteLine(calculation(-5d, 10d, 15d, 15d,10d, 14d));
        } 
        public static string calculation(double x1, double y1, double r1, double x2, double y2, double r2)
        {
            double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine(d);

            if (d > r1 + r2)
                return "Круги не пересекаются";
            if (d + r2 <= r1)
                return Convert.ToString(Math.PI * Math.Pow(r2, 2));

            double alpha = 2.0 * Math.Acos((Math.Pow(d, 2) + Math.Pow(r1, 2) - Math.Pow(r2, 2)) / (2.0 * d * r1));
            double beta = 2.0 * Math.Acos((Math.Pow(d, 2) + Math.Pow(r2, 2) - Math.Pow(r1, 2)) / (2.0 * d * r2));

            double S1 = Math.Pow(r1,2) * (alpha - Math.Sin(alpha))/2.0;
            double S2 = Math.Pow(r2, 2) * (alpha - Math.Sin(alpha)) / 2.0;

            return Convert.ToString(S1 + S2);
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
