using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF4
{
    internal class _4B
    {
        private static void Solve(string[] args)
        {
            var input= Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var d = input[0];
            var sumTime = input[1];

            Span<int> minTimes = stackalloc int[d];
            Span<int> maxTimes = stackalloc int[d];
            var actualTimes = new int[d];

            var minpossibletime = 0;
            var maxpossibletime = 0;

            for (int i = 0; i<d; i++)
            {
                input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                minTimes[i] = input[0];
                maxTimes[i] = input[1];
                minpossibletime += input[0];
                maxpossibletime += input[1];
            }

            if(minpossibletime<=sumTime && maxpossibletime>=sumTime)
            {
                Console.WriteLine("YES");
                var difftime= sumTime-minpossibletime;

                for (int i = 0;i<d;i++)
                {
                    if(difftime>0)
                    {
                        actualTimes[i] = Math.Min(minTimes[i]+difftime, maxTimes[i]);
                        difftime = difftime + minTimes[i] -actualTimes[i];
                    }
                    else actualTimes[i] = minTimes[i];
                }
                Console.WriteLine(string.Join(' ',actualTimes));
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
