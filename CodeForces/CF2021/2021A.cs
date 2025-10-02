using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2021
{
    internal class _2021A
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Array.Sort(a);

                for (int j = 1; j < n; j++)
                {
                    a[j] = (a[j] + a[j-1]) / 2;
                }

                Console.WriteLine(a[n-1]);
            }

        }
    }
}
