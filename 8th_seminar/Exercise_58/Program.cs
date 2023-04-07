// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] matrix1 = new int[3, 3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
int[,] matrix2 = new int[3, 3] { {9, 8, 7}, {6, 5, 4}, {3, 2, 1} };
int[,] resultMatrix = new int[3, 3];

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < 3; k++) {
            resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        Console.Write(resultMatrix[i, j] + " ");
    }
    Console.WriteLine();
}