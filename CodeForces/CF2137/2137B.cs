using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2137
{
    internal class _2137B
    {
        private void Solve()
        {
            var t = int.Parse(Console.ReadLine());

            int n;

            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());

                var p = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                Console.WriteLine(string.Join(' ', p.Select(x => n + 1 - x)));
            }
        }
    }
}
