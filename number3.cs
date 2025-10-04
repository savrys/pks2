using System;

class Program
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
    
    static void Main()
    {
        Console.Write("Введите числитель: ");
        int numerator = int.Parse(Console.ReadLine());
        
        Console.Write("Введите знаменатель: ");
        int denominator = int.Parse(Console.ReadLine());
        
        if (denominator == 0)
        {
            Console.WriteLine("Ошибка: знаменатель не может быть равен 0");
            return;
        }
        
        Console.WriteLine($"Исходная дробь: {numerator} / {denominator}");
        
        // Находим НОД
        int gcd = GCD(numerator, denominator);
        Console.WriteLine($"Наибольший общий делитель: {gcd}");
        
        // Сокращаем дробь
        int reducedNum = numerator / gcd;
        int reducedDen = denominator / gcd;
        
        // Убираем двойной минус
        if (reducedDen < 0)
        {
            reducedNum = -reducedNum;
            reducedDen = -reducedDen;
        }
        
        Console.WriteLine($"Сокращенная дробь: {reducedNum} / {reducedDen}");
    }
}
