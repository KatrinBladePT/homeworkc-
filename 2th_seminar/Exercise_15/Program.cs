﻿//  Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int.TryParse(Console.ReadLine()!, out int d);
if ( d > 7)
    { 
    Console.WriteLine("Не верный ввод номера дня недели");
    }
else
    {
        if ( d == 6 || d == 7)
        {
            Console.WriteLine("Выходной");
        }
        else {
            Console.WriteLine("Будний день");
        }
    }