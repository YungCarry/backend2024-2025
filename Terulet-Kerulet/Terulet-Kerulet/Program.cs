Console.Write("Adja meg a hosszuságot: ");
double h = double.Parse(Console.ReadLine());

Console.Write("Adja meg a szelesseget: ");
double sz = double.Parse(Console.ReadLine());

if (h > 0 && sz > 0)
{
    Console.WriteLine($"Kerület: {(h + sz) * 2}");
    Console.WriteLine($"Terület: {h*sz}");
}

else
{
    Console.WriteLine("hibás adat");
}