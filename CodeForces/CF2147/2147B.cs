using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2147
{
    internal class _2147B
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine());

                var a = Enumerable.Range(1, n).Reverse().
                    ToList();

                a.Add(n);

                a.AddRange(Enumerable.Range(1, n - 1));

                Console.WriteLine(string.Join(' ', a));
            }

        }

    }
}
