using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Leetcode.CodeForces.CF2179
{
    internal class _2179D
    {
        static void Solve(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);
            int n, exceed, step, seriesstart, seriesstep,cur;
            StringBuilder ans = new();

            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine()!);

                exceed = (int)Math.Pow(2, n);

                ans.Append(exceed-1);

                seriesstart = exceed/2 -1;
                step = exceed;
                seriesstep = exceed / 4;
                cur = seriesstart;

                while(step>=2)
                {
                    while(cur <exceed)
                    {
                        ans.Append(" ");
                        ans.Append(cur);
                        cur = cur+ step;
                    }

                    seriesstart -=seriesstep;
                    step /= 2;
                    seriesstep /= 2;
                    cur = seriesstart;
                }

                Console.WriteLine(ans.ToString());
                ans.Clear();
            }
        }
    }
}
