using System;

class Feladat4
{
    static void Main()
    {

        Console.Write("Adja meg az első oldal hosszát: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Adja meg a második oldal hosszát: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Adja meg a harmadik oldal hosszát: ");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("A háromszög szerkeszthető.");
        }
        else
        {
            Console.WriteLine("A háromszög nem szerkeszthető.");
        }
    }
}