using System;

class Feladat3
{
    static void Main()
    {

        Console.Write("Adja meg az 'a' értékét: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Adja meg a 'b' értékét: ");
        double b = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Nincs megoldása az egyenletnek.");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Az egyenlet megoldása: x = " + x);
        }
    }
}