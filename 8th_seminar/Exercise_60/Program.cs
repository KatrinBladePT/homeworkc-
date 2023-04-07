// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

using System;

namespace ThreeDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, ,] array = new int[2, 2, 2];
            int index = 10;
           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = index++; 
                        if (index > 99) index = 10; 
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine($"Элемент [{i}, {j}, {k}] = {array[i, j, k]}");
                    }
                }
            }
        }
    }
}
