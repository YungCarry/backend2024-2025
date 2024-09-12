using System;

class Feladat5
{
    static void Main()
    {
        Console.Write("Adja meg az x-kordinátát: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Adja meg az y-kordinátát: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Adja meg a sugart:  ");
        int r = int.Parse(Console.ReadLine());


        Console.Write("Adja meg az a-pontot: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Adja meg a b-pontot: : ");
        int b = int.Parse(Console.ReadLine());


        if (Math.Sqrt(x - a) + Math.Sqrt(y - b) <= Math.Sqrt(r))
            {
            Console.WriteLine("A pont nincs a körlemezen");
        }

        else
        { Console.WriteLine("A punt a körlemezen van."); }

    }
}