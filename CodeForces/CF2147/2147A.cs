using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2147
{
    internal class _2147A
    {
        private static void Solve(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (input[1] == 1) Console.WriteLine(-1);
                else if (input[0] > input[1] + 1) Console.WriteLine(3);
                else if (input[0] < input[1]) Console.WriteLine(2);
                else Console.WriteLine(-1);
            }
        }
    }
}
