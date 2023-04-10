// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, sum = 0;

            Console.Write("Введите значение M: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Введите значение N: ");
            n = int.Parse(Console.ReadLine());

            for (int i = m; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");
        }
    }
} 