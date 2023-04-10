// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using System;

namespace AckermannFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            while (true)
            {
                Console.WriteLine("Введите значение M:");
                if (int.TryParse(Console.ReadLine(), out m) && m >= 0)
                {
                    break;
                }
                Console.WriteLine("Ошибка ввода. Введите неотрицательное число.");
            }

            while (true) 
            {
                Console.WriteLine("Введите значение N:");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
                {
                    break;
                }
                Console.WriteLine("Ошибка ввода. Введите неотрицательное число.");
            }

            Console.WriteLine($"A({m},{n}) = {Ackermann(m, n)}"); 
        }

        static int Ackermann(int m, int n)
        {
            if (m == 0) 
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            else 
            {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
        }
    }
}
