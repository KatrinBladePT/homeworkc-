// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int.TryParse(Console.ReadLine()!, out int k);

if (k>999 || k<100)
{
    Console.WriteLine("Не трехзначное число!!!");
    return;
}
int GetSecond(int k)
{
    while (k >= 100) k /= 10;
    int d = k % 10;
    return d;
}
Console.WriteLine(GetSecond(k));
