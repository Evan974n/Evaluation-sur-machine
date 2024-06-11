using System;

class Programme
{
    static void Main()
    {
        Console.WriteLine("Saisir un entier: ");
        int nombre = Convert.ToInt32(Console.ReadLine());
    
        double[] nombresHarmoniques = CalculerNombresHarmoniques(nombre);

        Console.WriteLine("Le tableau résultat contient :");
        for (int i = 0; i < nombresHarmoniques.Length; i++)
    {
            Console.WriteLine($"({i + 1}) = {nombresHarmoniques[i]:F2}");
    }

    return res;
}

    static double[] CalculerNombresHarmoniques(int n)
    {
        double[] nombresHarmoniques = new double[n];
        double resultat = 0.0;

        for (int i = 1; i <= n; i++)
        {
            resultat = resultat + 1.0 / i;
            nombresHarmoniques[i - 1] = resultat;

        }

        return nombresHarmoniques;
    }
}
