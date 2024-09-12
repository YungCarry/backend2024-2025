Console.WriteLine("ADja meg az érdemjegyet");
double atlag = double.Parse(Console.ReadLine());


string ertekeles = atlag switch
{
    >= 1 and <= 1.49 => "elégtelen",
    >= 1.5 and <= 2.49 => "elégséges",
    >= 2.5 and <= 3.49 => "közepes",
    >= 3.5 and <= 4.49 => "jó",
    >= 4.5 and <= 5 => "kitünő",
    _ => "Nem valid érték"
};

Console.WriteLine(ertekeles);