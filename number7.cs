using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество модулей n: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Введите ширину модуля a: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введите высоту модуля b: ");
        int b = int.Parse(Console.ReadLine());
        
        Console.Write("Введите ширину поля w: ");
        int w = int.Parse(Console.ReadLine());
        
        Console.Write("Введите высоту поля h: ");
        int h = int.Parse(Console.ReadLine());
        
        int maxD = 0;
        
        Console.WriteLine("\nРасчет возможных вариантов:");
        Console.WriteLine($"Количество модулей: {n}");
        Console.WriteLine($"Размер модуля: {a} x {b} м");
        Console.WriteLine($"Размер поля: {w} x {h} м");
        Console.WriteLine(new string('-', 40));
        
        // Перебираем возможные значения d
        for (int d = 0; d <= Math.Min(w, h); d++)
        {
            // Размер модуля с защитой
            int moduleWidth = a + 2 * d;
            int moduleHeight = b + 2 * d;
            
            // Сколько модулей помещается по горизонтали и вертикали
            int horizontal = w / moduleWidth;
            int vertical = h / moduleHeight;
            int totalModules = horizontal * vertical;
            
            Console.WriteLine($"d = {d}: модуль {moduleWidth} x {moduleHeight}, " +
                            $"размещение {horizontal} x {vertical} = {totalModules} модулей");
            
            if (totalModules >= n)
            {
                maxD = d;
                Console.WriteLine($"Подходит! (нужно {n}, доступно {totalModules})");
            }
            else
            {
                Console.WriteLine($"Не подходит (нужно {n}, доступно {totalModules})");
                break;
            }
        }
        
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("РЕЗУЛЬТАТ:");
        Console.WriteLine($"Максимальная толщина защиты: d = {maxD} м");
        Console.WriteLine($"Размер модуля с защитой: {a + 2 * maxD} x {b + 2 * maxD} м");
        Console.WriteLine($"Максимальное количество модулей: {(w / (a + 2 * maxD)) * (h / (b + 2 * maxD))}");
    }
}
