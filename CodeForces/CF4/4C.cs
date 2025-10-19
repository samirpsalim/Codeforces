using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF4
{
    internal class _4C
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var dict = new Dictionary<string,int>();

            for(int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();

                if (dict.ContainsKey(name!))
                {
                    Console.WriteLine($"{name}{dict[name!]}");
                    dict[name!]++;
                }
                else
                {
                    Console.WriteLine("OK");
                    dict[name!] = 1;
                }
            }
        }
    }
}
