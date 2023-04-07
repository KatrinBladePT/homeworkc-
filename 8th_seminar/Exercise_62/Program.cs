// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] spiralArray = new int[4, 4];
int value = 1;
int topRow = 0, bottomRow = 3, leftColumn = 0, rightColumn = 3;

while (topRow <= bottomRow && leftColumn <= rightColumn)
{
    for (int i = leftColumn; i <= rightColumn; i++)
    {
        spiralArray[topRow, i] = value;
        value++;
    }
    topRow++;

    for (int i = topRow; i <= bottomRow; i++)
    {
        spiralArray[i, rightColumn] = value;
        value++;
    }
    rightColumn--;

    if (topRow <= bottomRow)
    {
        for (int i = rightColumn; i >= leftColumn; i--)
        {
            spiralArray[bottomRow, i] = value;
            value++;
        }
        bottomRow--;
    }

    if (leftColumn <= rightColumn)
    {
        for (int i = bottomRow; i >= topRow; i--)
        {
            spiralArray[i, leftColumn] = value;
            value++;
        }
        leftColumn++;
    }
}

for (int row = 0; row < spiralArray.GetLength(0); row++)
{
    for (int col = 0; col < spiralArray.GetLength(1); col++)
    {
        Console.Write(spiralArray[row, col].ToString().PadLeft(2) + " ");
    }
    Console.WriteLine();
}