using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите шестизначный номер билета: ");
        int ticket = int.Parse(Console.ReadLine());

        // Проверяем, что число шестизначное
        if (ticket < 100000 || ticket > 999999)
        {
            Console.WriteLine("Ошибка: введите корректный шестизначный номер");
            return;
        }

        // Получаем цифры билета
        int digit1 = ticket / 100000;
        int digit2 = (ticket / 10000) % 10;
        int digit3 = (ticket / 1000) % 10;
        int digit4 = (ticket / 100) % 10;
        int digit5 = (ticket / 10) % 10;
        int digit6 = ticket % 10;

        // Вычисляем суммы
        int sumFirst = digit1 + digit2 + digit3;
        int sumLast = digit4 + digit5 + digit6;

        // Выводим результат
        if (sumFirst == sumLast)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
