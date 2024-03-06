using System;
using System.Collections.Generic;
using System.Text;
//Два списки I та U містять результати виміру струму і 
//напруги на невідомому опорі R. Знайти наближене число 
//R методом найменших квадратів

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<double> I = new List<double> { 2.0, 1.0, 4.0 }; // Значення струмів
        List<double> U = new List<double> { 1.0, 1.0, 3.0 }; // Відповідні значення напруг
        double sumI = 0;
        double sumU = 0;
        double sumIU = 0;
        double sumI2 = 0;
        if (I.Count == U.Count)
        {
            for (int i = 0; i < U.Count; i++)
            {
                sumI += I[i];
                sumU += U[i];
                sumIU += I[i] * U[i];
                sumI2 += Math.Pow(I[i], 2);
            }

            double R = (I.Count * sumIU - sumI * sumU) / (I.Count * sumI2 - Math.Pow(sumI, 2));
            Console.WriteLine($"Наближене значення опору R: {R:F3}");
            Console.ReadKey();
        }
    }
}
