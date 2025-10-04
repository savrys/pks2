using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество бактерий: ");
        int bacteria = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество антибиотика: ");
        int antibiotic = int.Parse(Console.ReadLine());
        
        int hour = 0;
        int initialBacteria = bacteria;
        int initialAntibiotic = antibiotic;
        
        Console.WriteLine("\nНачало эксперимента:");
        Console.WriteLine($"Исходное количество бактерий: {bacteria}");
        Console.WriteLine($"Исходное количество антибиотика: {antibiotic} капель");
        Console.WriteLine(new string('-', 50));
        
        while (bacteria > 0 && antibiotic > 0 && hour < 20)
        {
            hour++;
            
            Console.WriteLine($"\nЧас {hour}:");
            Console.WriteLine($"Бактерий до размножения: {bacteria}");
            
            // Бактерии удваиваются
            bacteria *= 2;
            Console.WriteLine($"Бактерий после размножения: {bacteria}");
            
            // Антибиотик убивает бактерии
            int killPower = Math.Max(0, 11 - hour); // 10, 9, 8, ...
            int killed = Math.Min(bacteria, killPower * antibiotic);
            bacteria -= killed;
            
            Console.WriteLine($"Сила антибиотика: {killPower} бактерий/капля");
            Console.WriteLine($"Убито бактерий: {killed}");
            Console.WriteLine($"Бактерий осталось: {bacteria}");
            
            // Антибиотик перестает действовать после 10 часов на одну каплю
            if (hour >= 10)
            {
                antibiotic = 0;
                Console.WriteLine("Антибиотик перестал действовать!");
            }
            
            if (bacteria <= 0)
            {
                Console.WriteLine("Все бактерии уничтожены!");
                break;
            }
        }
        
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("ИТОГИ ЭКСПЕРИМЕНТА:");
        Console.WriteLine($"Исходное количество бактерий: {initialBacteria}");
        Console.WriteLine($"Исходное количество антибиотика: {initialAntibiotic}");
        Console.WriteLine($"Продолжительность эксперимента: {hour} часов");
        Console.WriteLine($"Финальное количество бактерий: {bacteria}");
        Console.WriteLine(bacteria > 0 ? "Бактерии выжили!" : "Бактерии уничтожены!");
    }
}
