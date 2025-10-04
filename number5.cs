using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество воды в мл: ");
        int water = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество молока в мл: ");
        int milk = int.Parse(Console.ReadLine());
        
        int americanoCount = 0;
        int latteCount = 0;
        int earnings = 0;
        int customers = 0;
        
        Console.WriteLine("\nНачало работы кофейного аппарата...");
        
        while (true)
        {
            customers++;
            Console.WriteLine($"\n--- Обслуживание клиента {customers} ---");
            Console.Write("Выберите напиток (1 — американо, 2 — латте): ");
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 1) // Американо
            {
                if (water >= 300)
                {
                    water -= 300;
                    americanoCount++;
                    earnings += 150;
                    Console.WriteLine("Ваш американо готов!");
                }
                else
                {
                    Console.WriteLine("Не хватает воды для приготовления американо");
                }
            }
            else if (choice == 2) // Латте
            {
                if (water >= 30 && milk >= 270)
                {
                    water -= 30;
                    milk -= 270;
                    latteCount++;
                    earnings += 170;
                    Console.WriteLine("Ваш латте готов!");
                }
                else if (water < 30)
                {
                    Console.WriteLine("Не хватает воды для приготовления латте");
                }
                else
                {
                    Console.WriteLine("Не хватает молока для приготовления латте");
                }
            }
            
            // Проверка, можно ли приготовить еще хотя бы один напиток
            bool canMakeAmericano = water >= 300;
            bool canMakeLatte = water >= 30 && milk >= 270;
            
            if (!canMakeAmericano && !canMakeLatte)
            {
                Console.WriteLine("\n" + new string('=', 50));
                Console.WriteLine("🏁 ИНГРЕДИЕНТЫ ЗАКОНЧИЛИСЬ - ФОРМИРОВАНИЕ ОТЧЕТА");
                Console.WriteLine(new string('=', 50));
                Console.WriteLine($"Остаток воды: {water} мл");
                Console.WriteLine($"Остаток молока: {milk} мл");
                Console.WriteLine($"Обслужено клиентов: {customers}");
                Console.WriteLine($"Приготовлено американо: {americanoCount} шт.");
                Console.WriteLine($"Приготовлено латте: {latteCount} шт.");
                Console.WriteLine($"Общая выручка: {earnings} рублей");
                Console.WriteLine(new string('=', 50));
                break;
            }
            
            Console.WriteLine($"Текущий остаток - Вода: {water} мл, Молоко: {milk} мл");
        }
    }
}
