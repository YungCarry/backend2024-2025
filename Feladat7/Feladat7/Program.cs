class Feladat7
{
    static void Main()
    {
        Console.WriteLine("Adja meg a víz hőfokát: ");
        double hofok = double.Parse(Console.ReadLine());

       if (hofok <= 0)
        {
            Console.WriteLine("szilárd");
        }

       else if (hofok >= 100)
        {
            Console.WriteLine("Gőz");
        }

       else
        {
            Console.WriteLine("Folyékony");
        }
    }
}