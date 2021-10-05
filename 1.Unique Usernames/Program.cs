using System;
using System.Collections.Generic;

namespace _1.Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            { 
                string name = Console.ReadLine();
                names.Add(name);
            }
            Console.WriteLine("============================");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============================");
        }
    }
}
