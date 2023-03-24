// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine()!, out int a);
Console.WriteLine("Введите степень числа");
int.TryParse(Console.ReadLine()!, out int n);

int myPow()
    {
        int pow = 1;
                for(int i=1;i<=n;i++)
                {
                   pow *= a ;
                }
               return pow;
    }           

int powNumber = myPow();
Console.WriteLine(powNumber);
