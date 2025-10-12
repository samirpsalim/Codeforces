using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2160
{
    internal class _2160B
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var b = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                Result(b, n);
            }

        }

        private static void Result(long[] b, int n)
        {
            int[] a = new int[n];
            a[0] = 1;

            for(int i=1; i<n; ++i)
            {
                if (b[i] - b[i - 1] == i + 1) a[i] = i + 1;
                else
                {
                    var pos = i + (int)(b[i - 1] - b[i]);
                    a[i] = a[pos];
                }
            }

            Console.WriteLine(string.Join(' ', a));
        }
    }
}
