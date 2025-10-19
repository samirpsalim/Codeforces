using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2154
{
    internal class _2154A
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var n = input[0];
                var k = input[1];
                var s = Console.ReadLine()!;
                Console.WriteLine(Process(s, k));
            }
        }

        private static int Process(string s, int k)
        {
            var count = 0;
            var prevone= int.MinValue;
            for(int i=0; i<s.Length; i++)
            {
                if(s[i] == '1')
                {
                    if(i-prevone >=k || prevone==int.MinValue) count++;
                    prevone = i;
                }
            }
            return count;
        }
    }
}
