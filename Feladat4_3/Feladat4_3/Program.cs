using System;

     Console.WriteLine("a) Hárommal osztható számok növekvő sorrendben 20-ig:");
        for (int i = 0; i <= 20; i += 3)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("b) 15-tel osztható kétjegyű számok csökkenő sorrendben:");
        for (int i = 99; i >= 15; i -= 15)
        {
            if (i >= 10)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine("\n");
  