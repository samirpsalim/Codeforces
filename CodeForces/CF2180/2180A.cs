using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2180
{
    internal class _2180A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++) 
            {
                var inputs = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var l = inputs[0];
                var a = inputs[1];
                var b = inputs[2];

                var gcd = GCD(l, b);

                Console.WriteLine((l - 1) - ((l - 1 - a) % gcd));
            }
        }

        private static int GCD(int l, int b)
        {
            if (l < b) return GCD(b, l);

            if (l % b == 0) return b;

            return GCD(b, l%b);

        }
    }
}
