Console.Write("Adja meg az n-értékét: ");
double n = double.Parse(Console.ReadLine());

if (n > 0)
{
    Console.WriteLine("Poz");
}

else if ( n < 0)
{
    Console.WriteLine("Neg");
}

else
{
    Console.WriteLine("0");
}