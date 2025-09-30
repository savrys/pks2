using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество модулей (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите размеры модуля (a b): ");
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        Console.Write("Введите размеры поля (w h): ");
        input = Console.ReadLine().Split();
        int w = int.Parse(input[0]);
        int h = int.Parse(input[1]);

        int maxD = CalculateMaxProtection(n, a, b, w, h);
        
        if (maxD == -1)
        {
            Console.WriteLine("Размещение невозможно");
        }
        else
        {
            Console.WriteLine($"Максимальная толщина защиты: {maxD}");
        }
    }

    static int CalculateMaxProtection(int n, int a, int b, int w, int h)
    {
        // Проверяем возможность размещения без защиты
        if (!CanPlaceModules(n, a, b, w, h, 0))
            return -1;

        // Бинарный поиск максимальной толщины
        int left = 0;
        int right = Math.Min(w, h);
        int result = 0;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (CanPlaceModules(n, a, b, w, h, mid))
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }

    static bool CanPlaceModules(int n, int a, int b, int w, int h, int d)
    {
        // Размеры модуля с защитой
        int aWithD = a + 2 * d;
        int bWithD = b + 2 * d;

        // Проверяем оба варианта ориентации
        return (w >= aWithD && h >= bWithD && CanFit(n, aWithD, bWithD, w, h)) ||
               (w >= bWithD && h >= aWithD && CanFit(n, bWithD, aWithD, w, h));
    }

    static bool CanFit(int n, int moduleWidth, int moduleHeight, int fieldWidth, int fieldHeight)
    {
        int maxInRow = fieldWidth / moduleWidth;
        int maxInColumn = fieldHeight / moduleHeight;
        
        return maxInRow * maxInColumn >= n;
    }
}
