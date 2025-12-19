using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2158
{
    internal class _2158A
    {
        public static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var cards = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(Math.Min(n, cards[1] + cards[0]/2));
                
            }
        }
    }
}
