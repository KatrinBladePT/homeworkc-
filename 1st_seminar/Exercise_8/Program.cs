//  Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

//  5 -> 2, 4
//  8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine()!, out int N);
int a = 1;

 while (a <= N)
     {if (a % 2 == 0) Console.WriteLine(a);
     a++;
     }


