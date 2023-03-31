// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

class Program
{
    static void Main(string[] args) {
        Console.Write("Введите количество значений для ввода: ");
        int.TryParse(Console.ReadLine(), out int m);

        int count = 0;

        for (int i = 0; i < m; i++) {
            Console.Write("Введите значение {0}: ");
            int.TryParse(Console.ReadLine(),out int number);

            if (number > 0) {
                count++;
            }
        }

        Console.WriteLine($"Количество значений больше 0: {count}");
    }
}
