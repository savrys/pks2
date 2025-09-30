using System;

class Program
{
    static void Main()
    {
        // Ввод чисел
        Console.Write("Введите числитель M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите знаменатель N: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("Ошибка: знаменатель не может быть равен 0");
            return;
        }

        // Находим НОД
        int gcd = FindGCD(Math.Abs(m), Math.Abs(n));

        // Сокращаем дробь
        int numerator = m / gcd;
        int denominator = n / gcd;

        // Корректируем знаки
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }

        // Выводим результат
        if (denominator == 1)
        {
            Console.WriteLine($"Несократимая дробь: {numerator}");
        }
        else
        {
            Console.WriteLine($"Несократимая дробь: {numerator}/{denominator}");
        }
    }

    // Метод для нахождения НОД (алгоритм Евклида)
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
