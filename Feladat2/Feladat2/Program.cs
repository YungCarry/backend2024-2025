using System;

class Feladat2
{
    static void Main()
    {
        Console.Write("Adja meg az intervallum elejét: ");
        int intervallumEleje = int.Parse(Console.ReadLine());

        Console.Write("Adja meg az intervallum végét: ");
        int intervallumVege = int.Parse(Console.ReadLine());

        if (intervallumEleje > intervallumVege)
        {
            Console.WriteLine("Az intervallum hibásan van megadva.");
        }
        else
        {
            Console.WriteLine("Az intervallum helyesen van megadva.");
        }
    }
}