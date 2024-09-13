using System;

Console.Write("Adja meg az a- értékét: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Adja meg az b- értékét: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Adja meg az c- értékét: ");
double c = double.Parse(Console.ReadLine());


double d = (Math.Sqrt(b) - 4 * a * x);

if (d < 0 )
{
    Console.WriteLine("Nincs valós gyök");
}

else
{
    if (d = 0)
    {
        double x = -b / 2 * a;
        Console.WriteLine($"A gyök: " x);


    }

    else
    {
        double x1 = -b + Math.Sqrt(d) / 2 * a;
        double x2 = -b - Math.Sqrt(d) / 2 * a;

        Console.WriteLine($"A gyökök:  " x1 " " x2);
    }
};