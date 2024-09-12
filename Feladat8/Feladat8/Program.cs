Console.WriteLine("Adja meg az x kordinátát: ");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Adja meg az y kordinatat: ");
double y = double.Parse(Console.ReadLine()); 

if (x > 0 && y > 0)
{
    Console.WriteLine("1. negyed");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("2. negyed");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("3. negyed");
}

else if (x > 0 && y < 0)
{
    Console.WriteLine("4. negyed");
}

else
{
    Console.WriteLine("A pont az origoban van");
}