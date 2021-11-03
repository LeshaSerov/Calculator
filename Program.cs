using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double calc(double x, string? s, double y)
        {
            double result = 0;
            if (s == "+")
                result = x + y;
            if (s == "-")
                result = x - y;
            if (s == "*")
                result = x * y;
            if (s == "/")
                result = x / y;
            if (s == "^")
                result = Math.Pow(x, y);
            return result;
        }
        static double calc_spec(double x, string? s)
        {
            double result = 0;
            if (s == "sin")
                result = Math.Sin(x);
            if (s == "cos")
                result = Math.Cos(x);
            if (s == "tan")
                result = Math.Tan(x);
            if (s == "ctan")
                result = 1 / Math.Tan(x);
            return result;
        }

        static void Main()
        {
            Console.Write(" Первое число: ");
            bool parsed = double.TryParse(Console.ReadLine(), out double x);
            while (!parsed)
            {
                Console.WriteLine(" Это не число!");
                Console.Write(" Первое число: ");
                parsed = double.TryParse(Console.ReadLine(), out x);
            }

            Console.Write(" Знак: ");
            string? s = Console.ReadLine();
            while (!((s == "+") ^ (s == "-") ^ (s == "/") ^ (s == "*") ^ (s == "sin") ^ (s == "cos") ^ (s == "^") ^ (s == "tan") ^ (s == "ctan")))
            {
                Console.WriteLine(" Это не входит в заданный список математических операций!");
                Console.Write(" Знак: ");
                s = Console.ReadLine();
            }

            double result;

            if (!((s != "sin") ^ (s != "cos") ^ (s != "tan") ^ (s != "ctan")))
            {
                Console.Write(" Второе число: ");
                parsed = double.TryParse(Console.ReadLine(), out double y);
                while (!parsed)
                {
                    Console.WriteLine(" Это не число!");
                    Console.Write(" Второе число: ");
                    parsed = double.TryParse(Console.ReadLine(), out y);
                }
                result = calc(x, s, y);
            }
            else
            {
                result = calc_spec(x, s);
            }
            Console.WriteLine($" Результат: {result}");


            //Console.WriteLine($@" Черех 15 лет - Возраст {ageToDouble}");
            //Console.WriteLine(@" Черех 15 лет - Возраст {ageToDouble}");

            //Console.Write(x);
            /*
            string z  = Console.ReadLine();                                 //как получить нужный тип 
            if (flag) Console.WriteLine(x);
            z = (x).ToString();
            */

            //flag = string.TryParse(x, out x);
            //string y = x.ToString();

            //Console.Write(y);
            //Console.ReadKey(); //char ''
        }
    }
}
