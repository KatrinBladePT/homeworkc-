﻿// Задача 23

// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N=0;
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out N);

for(int i=1;i<=N;i++)
{
        Console.WriteLine($"{i}x{i}x{i}={i*i*i}");
}
