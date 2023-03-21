// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
string someNumbers = Console.ReadLine()!;
if (someNumbers.Length < 3)
{
    Console.WriteLine("Не трехзначное число");
    return;
}
Console.WriteLine(someNumbers[2]);
