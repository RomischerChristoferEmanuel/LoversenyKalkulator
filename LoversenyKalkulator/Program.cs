List<double> vegosszeg = new List<double>();
double atlag = 0;
for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"{i}. ló adatai:");
    Console.Write("\tLó neve:");
    string lonev = Console.ReadLine();

    Console.Write("\tBérelt napok (db): ");
    int napok = int.Parse(Console.ReadLine());

    Console.Write("\tKiemelt VIP box (true/false): ");
    bool vip = bool.Parse(Console.ReadLine());

    if (napok >= 7)
    {
        double osszeg = (15000 * napok) * 0.85;
        vegosszeg.Add(osszeg);
    }
    else if (vip)
    {
        double osszeg = (15000 * napok) * 0.85;
        vegosszeg.Add(osszeg);
    }

    else if (napok >= 3)
    {
        double osszeg = (15000 * napok) * 0.95;
        vegosszeg.Add(osszeg);
    }

    else
    {
        double osszeg = 15000 * napok;
        vegosszeg.Add(osszeg);
    }

    for (i = 1; i <= 4; i++)
    {
        Console.WriteLine("Rögzített bérleti díjak:");
        Console.WriteLine($"\t- {i}. bérlés adatai: {vegosszeg[i]}");

    }


    double napteljes = 0;
    napteljes += vegosszeg[i];
    Console.WriteLine($"Napi teljes bevétel: {napteljes} Ft");
    atlag = napteljes / 4;
    Console.WriteLine($"Átlagos bérleti díj: {atlag} Ft");

    if (napteljes >= 200000)
    {
        Console.WriteLine("Kiemelkedő forgalmú nap!");
    }
    else if (napteljes >= 100000)
    {
        Console.WriteLine("Átlagos forgalmú nap.");
    }
    else
    {
        Console.WriteLine("Gyenge forgalmú nap.");
    }
}

