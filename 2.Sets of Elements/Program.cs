using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            int[] sets = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < sets[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set1.Add(num);
            }

            for (int i = 0; i < sets[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set2.Add(num);
            }
            Console.WriteLine("===============================");
            set1.IntersectWith(set2);
            Console.WriteLine(string.Join(' ', set1));
            Console.WriteLine("===============================");
        }
    }
}
