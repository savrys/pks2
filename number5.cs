using System;

class CoffeeMachine
{
    private const int AMERICANO_WATER = 300;
    private const int LATTE_WATER = 30;
    private const int LATTE_MILK = 270;
    private const int AMERICANO_PRICE = 150;
    private const int LATTE_PRICE = 170;

    private int water;
    private int milk;
    private int americanoCount = 0;
    private int latteCount = 0;
    private int totalEarnings = 0;

    public void Start()
    {
        Console.Write("Введите количество воды (мл): ");
        water = int.Parse(Console.ReadLine());

        Console.Write("Введите количество молока (мл): ");
        milk = int.Parse(Console.ReadLine());

        while (true)
        {
            if (!CanMakeAnyDrink())
            {
                ShowReport();
                break;
            }

            ProcessOrder();
        }
    }

    private void ProcessOrder()
    {
        Console.WriteLine("\nВыберите напиток:");
        Console.WriteLine("1 - Американо");
        Console.WriteLine("2 - Латте");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                MakeAmericano();
                break;
            case 2:
                MakeLatte();
                break;
            default:
                Console.WriteLine("Неверный выбор");
                break;
        }
    }

    private void MakeAmericano()
    {
        if (water >= AMERICANO_WATER)
        {
            water -= AMERICANO_WATER;
            americanoCount++;
            totalEarnings += AMERICANO_PRICE;
            Console.WriteLine("Ваш напиток готов");
        }
        else
        {
            Console.WriteLine("Не хватает воды");
        }
    }

    private void MakeLatte()
    {
        if (water >= LATTE_WATER && milk >= LATTE_MILK)
        {
            water -= LATTE_WATER;
            milk -= LATTE_MILK;
            latteCount++;
            totalEarnings += LATTE_PRICE;
            Console.WriteLine("Ваш напиток готов");
        }
        else if (water < LATTE_WATER)
        {
            Console.WriteLine("Не хватает воды");
        }
        else
        {
            Console.WriteLine("Не хватает молока");
        }
    }

    private bool CanMakeAnyDrink()
    {
        return (water >= AMERICANO_WATER) || (water >= LATTE_WATER && milk >= LATTE_MILK);
    }

    private void ShowReport()
    {
        Console.WriteLine("\n*Отчёт*");
        Console.WriteLine("Ингредиенты подошли к концу");
        Console.WriteLine($"Остаток воды: {water} мл");
        Console.WriteLine($"Остаток молока: {milk} мл");
        Console.WriteLine($"Кружек американо приготовлено: {americanoCount}");
        Console.WriteLine($"Кружек латте приготовлено: {latteCount}");
        Console.WriteLine($"Итого: {totalEarnings} рублей");
    }

    static void Main()
    {
        CoffeeMachine machine = new CoffeeMachine();
        machine.Start();
    }
}
