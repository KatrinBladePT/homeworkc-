// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        if (n < 1)
            return;

        Console.WriteLine(n);
        PrintNumbers(n - 1);
    }
}