using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Wardrobe
{
    class Program
    { 
        public static void FillWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, string colour, List<string> items)
        {
            for (int j = 0; j < items.Count; j++)
            {
                if (wardrobe[colour].ContainsKey(items[j]) == false)
                {
                    wardrobe[colour].Add(items[j], 1);
                }
                else
                {
                    wardrobe[colour][items[j]]++;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string colour = input[0];

                List<string> items = input[1].Split(',').ToList();

                if (wardrobe.ContainsKey(colour) == false)
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                    FillWardrobe(wardrobe, colour, items);

                }
                else
                {
                    FillWardrobe(wardrobe, colour, items);
                }
            }
            string[] lookingFor = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var colour in wardrobe)
            {
                Console.WriteLine($"{colour.Key} clothes:");
                foreach (var item in colour.Value)
                {
                    if (item.Key == lookingFor[1] && lookingFor[0] == colour.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }

                }
            }
        }
    }
}
