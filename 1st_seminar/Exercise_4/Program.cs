//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine()!, out int a);

Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine()!, out int b);

Console.WriteLine("Введите третье число");
int.TryParse(Console.ReadLine()!, out int c);

int Max(int a, int b, int c)
{
int result = a;
if(b>result) result=b;
if(c>result) result=c;
return result;
}

Console.WriteLine($"max = {Max(a,b,c)}");

