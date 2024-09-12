using System;

class Feladat1
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a foglalt helyek számát: ");
        int foglaltHelyek = int.Parse(Console.ReadLine());

        Console.Write("Kérem, adja meg az összes helyek számát: ");
        int osszesHelyek = int.Parse(Console.ReadLine());

        if (foglaltHelyek > osszesHelyek)
        {
            Console.WriteLine("Helytelen értékmegadás. A foglalt helyek száma nem lehet több, mint az összes helyek száma!");
        }
        else
        {
            Console.WriteLine("Az adatok helyesek.");
        }
    }
}