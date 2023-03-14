//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine()!, out int a);

Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine()!, out int b);

int max = a;

if (a > b) max = a;
if (b > a) max = b;

Console.WriteLine($"max = {max}");