Console.Write("Add meg az első számot: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Add meg a második számot: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Add meg a harmadik számot: ");
double c = double.Parse(Console.ReadLine());


double[] szamok = { a, b, c };
Array.Sort(szamok);
Array.Reverse(szamok);

Console.WriteLine("A számok sorrendben:");
foreach (double i in szamok)
{
    Console.WriteLine(i);
}