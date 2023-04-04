// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



    int[,] array = new int [,] {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4}
    };
        
    Console.WriteLine("Введите позиции элемента в двумерном массиве:");
    Console.Write("Строка: ");
    int.TryParse(Console.ReadLine()!, out int row);
    Console.Write("Столбец: ");
    int.TryParse(Console.ReadLine()!, out int column);    
    if (row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1)) {
            Console.WriteLine("Такого элемента нет.");
    }
    else {
            Console.WriteLine($"Элемент [{row}, {column}] = {array[row, column]}");
    }
