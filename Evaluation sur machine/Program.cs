using System;

double nbHarmoniques(double a)
{
    double res = 0.0;
    

    for (int i = 1; i <= a; i++)
    {
        res = 1.0 / i;
    }

    return res;
}



double n;
Console.WriteLine("Saisir un entier: ");
n = Convert.ToDouble(Console.ReadLine());

double nbHarmonique = nbHarmoniques(n) ;
Console.WriteLine($"Le nombre harmonique H({n}) est : {nbHarmoniques}");
