using System;

class Program
{
    static void Main()
    {
        int low = 0;
        int high = 63;
        int questions = 0;
        
        Console.WriteLine("Загадайте число от 0 до 63. Отвечайте: 1 - да, 0 - нет");
        Console.WriteLine("------------------------------------------------------");
        
        for (int i = 0; i < 7; i++)
        {
            int mid = (low + high) / 2;
            Console.Write($"Вопрос {i + 1}: Ваше число больше {mid}? ");
            int answer = int.Parse(Console.ReadLine());
            questions++;
            
            if (answer == 1)
                low = mid + 1;
            else
                high = mid;
            
            Console.WriteLine($"Диапазон поиска: [{low}, {high}]");
        }
        
        Console.WriteLine("======================================");
        Console.WriteLine($"Загаданное число: {low}");
        Console.WriteLine($"Угадано за {questions} вопросов");
    }
}
