using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2154
{
    internal class _2154B
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(Process(a,n));
            }
        }

        private static long Process(int[] a, int n)
        {
            long count = 0;
            int prevmax = a[0];

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    if (prevmax > a[i]) a[i] = prevmax;
                    else if (a[i] > prevmax) prevmax = a[i];

                    if (a[i - 1] >= prevmax)
                    {
                        count += a[i - 1] + 1 - prevmax;
                        a[i - 1] = prevmax - 1;
                    }
                }
                else
                {
                    if (a[i]>prevmax) prevmax =a[i];
                    if (a[i] >= a[i-1])
                    {
                        count += a[i] + 1 - a[i - 1];
                        a[i] = a[i - 1] - 1;
                    }
                }
            }
            return count;
        }
    }
}
