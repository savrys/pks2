using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество бактерий (N): ");
        int bacteria = int.Parse(Console.ReadLine());

        Console.Write("Введите количество капель антибиотика (X): ");
        int x = int.Parse(Console.ReadLine());

        int killPower = 10;
        int hour = 0;

        Console.WriteLine("\nДинамика изменения количества бактерий:");

        while (killPower > 0 && bacteria > 0)
        {
            hour++;
            
            // Бактерии удваиваются
            bacteria *= 2;
            
            // Антибиотик убивает бактерии
            int killed = Math.Min(bacteria, killPower * x);
            bacteria -= killed;
            
            // Мощность антибиотика уменьшается
            killPower--;
            
            Console.WriteLine($"После {hour} часа бактерий осталось {bacteria}");
            
            // Проверка условий завершения
            if (bacteria <= 0 || killPower <= 0)
                break;
        }

        Console.WriteLine($"\nПроцесс завершен через {hour} часов");
        Console.WriteLine($"Конечное количество бактерий: {bacteria}");
    }
}
