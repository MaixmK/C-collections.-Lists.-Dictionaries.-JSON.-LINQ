using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<double> I = new List<double> { 2.0, 1.0, 4.0 }; // Значення струмів
        List<double> U = new List<double> { 1.0, 1.0, 3.0 }; // Відповідні значення напруг
        double sum1 = 0;
        double sum2 = 0;
        double sum3 = 0;
        double sum4 = 0;
        if (I.Count == U.Count)
        {
            for (int i = 0; i < U.Count; i++)
            {
                sum1 += I[i];
                sum2 += U[i];
                sum3 += I[i] * U[i];
                sum4 += Math.Pow(I[i], 2);
            }

            double R = (I.Count * sum3 - sum1 * sum2) / (I.Count * sum4 - Math.Pow(sum1, 2));
            Console.WriteLine($"Наближене значення опору R: {R:F3}");
            Console.ReadKey();
        }
    }
}
