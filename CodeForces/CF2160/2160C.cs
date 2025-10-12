using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2160
{
    internal class _2160C
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                Console.WriteLine(PalindromeWithEvenOnes(n)?"YES":"NO");
            }
        }

        private static bool PalindromeWithEvenOnes(int n)
        {
            StringBuilder representation = new StringBuilder("");
            bool started = false;
            int truecount = 0;

            while(n>0)
            {
                if (n % 2 == 1)
                {
                    started = true;
                    truecount++;
                    representation.Append("1");
                }
                else if(started)
                {
                    representation.Append("0");
                }
                n = n >> 1;
            }

            if(truecount %2 ==1) return false;

            string representationstring = representation.ToString();

            return string.Equals(representationstring,new string(representationstring.Reverse().ToArray()));

        }
    }
}
