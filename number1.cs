using System;

class Program
{
    // Функция для вычисления факториала
    static double Factorial(int n)
    {
        if (n == 0) return 1;
        double result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    // Функция для вычисления n-го члена ряда Маклорена для sin(x)
    static double GetNthTerm(double x, int n)
    {
        // sin(x) = x - x³/3! + x⁵/5! - x⁷/7! + ...
        int power = 2 * n + 1;
        double term = Math.Pow(x, power) / Factorial(power);
        return (n % 2 == 0) ? term : -term;
    }

    // Функция для вычисления суммы ряда с заданной точностью
    static double CalculateSeries(double x, double epsilon)
    {
        double sum = 0;
        double term = x; // Первый член ряда (n=0)
        int n = 0;

        while (Math.Abs(term) > epsilon)
        {
            sum += term;
            n++;
            term = GetNthTerm(x, n);
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Введите x:");
        double x = double.Parse(Console.ReadLine());

        // Вычисление с заданной точностью
        Console.WriteLine("Введите точность (e < 0.01):");
        double epsilon = double.Parse(Console.ReadLine());
        if (epsilon >= 0.01)
        {
            Console.WriteLine("Точность должна быть меньше 0.01");
            return;
        }

        double result = CalculateSeries(x, epsilon);
        Console.WriteLine($"Значение sin(x) с точностью {epsilon}: {result}");
        Console.WriteLine($"Проверка Math.Sin(x): {Math.Sin(x)}");

        // Вычисление n-го члена
        Console.WriteLine("\nВведите номер члена ряда (n):");
        int n = int.Parse(Console.ReadLine());
        double nthTerm = GetNthTerm(x, n);
        Console.WriteLine($"Значение {n}-го члена ряда: {nthTerm}");
    }
}
