using System;

class Program
{
    static void Main()
    {
        // Ввод x
        Console.Write("Введите x (|x| < 1): ");
        double x = double.Parse(Console.ReadLine());

        // Проверка области определения
        if (Math.Abs(x) >= 1)
        {
            Console.WriteLine("Ошибка: |x| должен быть < 1");
            return;
        }

        // Ввод точности
        Console.Write("Введите точность e (e < 0.01): ");
        double e = double.Parse(Console.ReadLine());

        if (e >= 0.01)
        {
            Console.WriteLine("Ошибка: точность должна быть < 0.01");
            return;
        }

        // Вычисление суммы ряда с заданной точностью
        double sum = 0;
        double term;
        int k = 0;

        do
        {
            term = 2 * Math.Pow(x, 2 * k + 1) / (2 * k + 1);
            sum += term;
            k++;
        } while (Math.Abs(term) >= e);

        Console.WriteLine($"Приближенное значение f(x): {sum:F6}");
        Console.WriteLine($"Точное значение f(x): {Math.Log((1 + x) / (1 - x)):F6}");

        // Вычисление n-го члена ряда
        Console.Write("Введите n (для n-го члена): ");
        int n = int.Parse(Console.ReadLine());

        double nthTerm = 2 * Math.Pow(x, 2 * (n - 1) + 1) / (2 * (n - 1) + 1);
        Console.WriteLine($"n-й член ряда: {nthTerm:F6}");
    }
}
