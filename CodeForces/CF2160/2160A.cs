using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2160
{
    internal class _2160A
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(Mex(a.ToHashSet(), n));
            }

        }

        private static int Mex(HashSet<int> hashSet, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (!hashSet.Contains(i)) return i;
            }
            return n;
        }
    }
}
