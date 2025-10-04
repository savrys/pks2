using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер билета (6 цифр): ");
        int ticket = int.Parse(Console.ReadLine());
        
        // Получаем цифры билета
        int digit1 = ticket / 100000;
        int digit2 = (ticket / 10000) % 10;
        int digit3 = (ticket / 1000) % 10;
        int digit4 = (ticket / 100) % 10;
        int digit5 = (ticket / 10) % 10;
        int digit6 = ticket % 10;
        
        // Сравниваем суммы
        bool isLucky = (digit1 + digit2 + digit3) == (digit4 + digit5 + digit6);
        
        Console.WriteLine(isLucky);
    }
}
