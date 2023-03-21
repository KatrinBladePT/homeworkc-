// Задача 21

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double x1 = 0;
double y1 = 0;
double z1 = 0;
double x2 = 0;
double y2 = 0;
double z2 = 0;

 Console.WriteLine("Введите координаты первой точки: ");
        Console.Write("x1 = ");
        x1 = double.Parse(Console.ReadLine()!);
        Console.Write("y1 = ");
        y1 = double.Parse(Console.ReadLine()!);
        Console.Write("z1 = ");
        z1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("\nВведите координаты второй точки: ");
        Console.Write("x2 = ");
        x2 = double.Parse(Console.ReadLine()!);
        Console.Write("y2 = ");
        y2 = double.Parse(Console.ReadLine()!);
        Console.Write("z2 = ");
        z2 = double.Parse(Console.ReadLine()!);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine($"\nРасстояние между двумя точками равно {distance:F2}");