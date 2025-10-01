using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2137
{
    internal class _2137C
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            long a,b;

            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                a = long.Parse(input[0]);
                b = long.Parse(input[1]);

                if (b % 2 == 1 && a%2==1) 
                {
                    Console.WriteLine(a * b + 1);
                }
                else if (b % 4 == 0 || (b % 2 == 0 && a % 2 == 0))
                {
                    Console.WriteLine(2 + a * b / 2);
                }
                else
                {
                    Console.WriteLine(-1);
                }

            }
        }
    }
}
