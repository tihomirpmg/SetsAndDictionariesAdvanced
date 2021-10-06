using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elem = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int k = 0; k < elem.Length; k++)
                {
                    elements.Add(elem[k]);
                }
            }
            Console.WriteLine(string.Join(' ', elements.OrderBy(x => x)));
        }
    }
}
