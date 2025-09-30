using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Загадайте число от 0 до 63. Я попробую его угадать.");
        Console.WriteLine("Отвечайте '1' (да) или '0' (нет) на мои вопросы.");

        int lower = 0;
        int upper = 63;
        int result = 0;

        for (int i = 5; i >= 0; i--)
        {
            int mid = lower + (1 << i); // 2^i
            Console.Write($"Ваше число больше или равно {mid}? (1/0): ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                result |= (1 << i); // Устанавливаем бит
                lower = mid;
            }
            else
            {
                upper = mid - 1;
            }
        }

        Console.WriteLine($"Ваше число: {result}");
    }
}
