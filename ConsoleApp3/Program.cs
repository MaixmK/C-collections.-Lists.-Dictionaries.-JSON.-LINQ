using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
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
    }
}
