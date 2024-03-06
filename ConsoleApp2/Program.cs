using System.Text;
using System.Text.Json;
//Дано масив словників. Реалізувати пошук по ключах кожного словника
//і вивести кількість знайдених результатів на екран.
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
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
        
        
        if (count > 0)
        {
            Dictionary<int, int> results = new Dictionary<int, int>()
            {
                {count, searchKey}
            };
            string jsonString=JsonSerializer.Serialize(results);
            string filePath = "result.json";
            File.WriteAllText(filePath, jsonString );
            Console.WriteLine("Результат було збережено в json файл.");
        }
        else
        {
            Console.WriteLine("Результат не було знайдено.");
        }

    }
}
