using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> elLogs = new Dictionary<char, int>();
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (elLogs.ContainsKey(input[i]) == false)
                {
                    elLogs.Add(input[i], 1);
                }
                else
                {
                    elLogs[input[i]]++;
                }
            }

            foreach (var el in elLogs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{el.Key}: {el.Value} time/s");
            }
        }
    }
}
