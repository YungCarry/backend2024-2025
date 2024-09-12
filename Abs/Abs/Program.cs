Console.WriteLine("Adje meg az a értékét: ");
double a = double.Parse(Console.ReadLine()); 

if (a < 0)
{
    a = -a;
    Console.WriteLine(a);
}

else
{
    Console.WriteLine("Hiba");
}