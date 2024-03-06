using System;
using System.Linq;
//Дана послідовність непустих рядків. Отримати послідовність символів,
//яка визначається наступним чином: якщо відповідний рядок вихідної
//послідовності має непарну довжину, то в якості символу береться перший
//символ цього рядка; в іншому випадку береться останній символ рядка.
//Відсортувати отримані символи за спаданням їх ascii кодів.
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
