using System;

namespace Lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ReadLine();
            Solution(ReadNumber('a'), ReadNumber('b'), ReadNumber('c'));  
        }

        /// <summary>
        /// Ввод и проверка
        /// </summary>
        /// <param name="t">Отображение названия коэффициента</param>
        /// <returns>Введенный коэффициент</returns>
        static double ReadNumber(char t) 
        {
            double r = 0;
            bool k = true;
            do
            {
                Console.Write("Write " + t + ": ");
                k = Double.TryParse(Console.ReadLine(), out r);
            } while (!k);
            return r;
        }

        /// <summary>
        /// решение уравнения
        /// </summary>
        static void Solution(double a, double b, double c) 
        {
            if (a == 0) //поиск решений
            {
                if (b != 0)
                {
                    Console.WriteLine("\nAnswer: " + -c / b);
                }
                else
                {
                    if (c != 0)
                        Console.WriteLine("\nNo solution");
                    else
                        Console.WriteLine("\nInfinite numbers of solutions");
                }
            }
            else
            {
                if (b != 0)
                {
                    if (c != 0)
                    {
                        double d = Math.Sqrt(b * b - 4 * a * c);
                        if (d >= 0)
                        {
                            Console.WriteLine("\nx1 = " + (-b - d) / (2 * a));
                            Console.WriteLine("x2 = " + (-b + d) / (2 * a));
                        }
                        else
                        {
                            Console.WriteLine("\nNo real solution");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nx1 = " + 0);
                        Console.WriteLine("x2 = " + -b / a);
                    }
                }
                else
                {
                    double r = -c / a;
                    if (r >= 0)
                    {
                        Console.WriteLine("\nx1 = " + -Math.Sqrt(r));
                        Console.WriteLine("x2 = " + Math.Sqrt(r));
                    }
                    else
                        Console.WriteLine("\nNo real solution");
                }
            }
        }

    }
}
