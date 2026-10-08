List<double> vegosszeg = new List<double>();
double atlag = 0;
for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"{i}. ló adatai:");
    Console.Write("\tLó neve:");
    string lonev= Console.ReadLine();

    Console.Write("\tBérelt napok (db): ");
    int napok=int.Parse(Console.ReadLine());

    Console.Write("\tKiemelt VIP box (true/false): ");
    bool vip=bool.Parse(Console.ReadLine());
    
    if (napok >= 7)
    {
        double osszeg = (15000 * napok)*0.85;
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

  
}


