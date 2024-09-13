using System;

Console.WriteLine("a");
for (int i = 1; i <= 9; i++)
{
    Console.Write(i);
    if (i < 9)
    {
        Console.Write(",");
    }
}
Console.WriteLine();

Console.WriteLine("\nb");
for (int i = 1; i <= 19; i += 2)
{
    Console.Write(i);
    if (i < 19)
    {
        Console.Write(",");
    }
}
Console.WriteLine();

Console.WriteLine("\nc");
for (int i = 9; i >= 1; i--)
{
    Console.Write(i);
    if (i > 1)
    {
        Console.Write(",");
    }
}
Console.WriteLine();