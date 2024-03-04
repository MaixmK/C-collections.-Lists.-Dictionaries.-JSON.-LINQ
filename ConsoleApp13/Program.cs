using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        //1 завдання
        Console.OutputEncoding = Encoding.UTF8;
        List<double> I = new List<double> { 2.0, 1.0, 4.0 }; // струм
        List<double> U = new List<double> { 1.0, 1.0, 3.0 }; // напругa
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

            Console.WriteLine($"Наближене значення опору R: {R}");
            Console.ReadKey();
            Console.WriteLine("=========================");


            //2 завдання
            Dictionary<int, string>[] dictionaries = new Dictionary<int, string>[]
            {
            new Dictionary<int, string> { { 2, "Elephant" }, {1, "Tiger" } },
            new Dictionary<int, string> { { 1, "Lion" }, {2, "Monkey" } },
            new Dictionary<int, string> { { 1, "Penguin" }, {3, "Zebra" } }
            };
            int count = 0;
            Console.Write("Введіть ключ: ");
            int searchKey = int.Parse(Console.ReadLine());
            foreach (var dictionary in dictionaries)
            {
                if (dictionary.ContainsKey(searchKey))
                {
                    count++;
                }
            }
            Console.WriteLine($"Кількість знайдених результатів для ключа '{searchKey}': {count}");
            Console.ReadKey();

        }
        Console.ReadKey();
        Console.WriteLine("=========================");
        
        
        //3 завдання
        List<string> list = new List<string>() { "dog", "cat", "rabbit", "hamster", "mouse", "parrot" };
        var result = list
            .Where(s => s.Length % 2 != 0)
            .Select(s => s[0])
            .Concat(
                list
                .Where(s => s.Length % 2 == 0)
                .Select(s => s[s.Length - 1])
            )
            .OrderByDescending(s => s);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }

}

