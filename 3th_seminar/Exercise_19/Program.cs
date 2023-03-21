// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
var number = Console.ReadLine();

void Pallindrom(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"{number} палиндром.");
  }
  else Console.WriteLine($"{number} НЕ палиндром.");
}

if (number!.Length == 5){
  Pallindrom(number);
}
else Console.WriteLine($"Неверный ввод");
