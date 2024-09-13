using System;

    Console.WriteLine("1. 5,6,7,8,9 számok:");
        for (int i = 5; i <= 9; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("2. Kétjegyű számok:");
        for (int i = 10; i <= 99; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("3. Húsznál kisebb kétjegyű számok:");
        for (int i = 10; i < 20; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("4. Egyjegyű páros számok:");
        for (int i = 0; i <= 8; i += 2)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("5. 100-nál kisebb, tízzel osztható számok:");
        for (int i = 0; i < 100; i += 10)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("6. 100-nál kisebb, hárommal osztható számok:");
        for (int i = 0; i < 100; i += 3)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("7. 9,8,7,6,5,4,3,2,1,0 számok:");
        for (int i = 9; i >= 0; i--)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("8. 9,8,7,6,5 számok:");
        for (int i = 9; i >= 5; i--)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("9. Egyjegyű negatív számok csökkenő sorrendben:");
        for (int i = -1; i >= -9; i--)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("10. Egyjegyű negatív számok növekvő sorrendben:");
        for (int i = -9; i <= -1; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("11. Negatív páros számok -20-ig csökkenő sorrendben:");
        for (int i = -2; i >= -20; i -= 2)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");
    }
}