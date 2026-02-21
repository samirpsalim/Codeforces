using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2178
{
    internal class _2178B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var s = Console.ReadLine()!;

                var ans = 0;

                if (s[0] == 'u') ans++;

                if (s[s.Length - 1] == 'u') ans++;

                var sindices = new int[2];

                for(int j=1; j< s.Length -1;++j)
                {
                    if (s[j] == 'u') sindices[j%2]++;
                    else
                    {
                        ans += sindices.Min();
                        sindices[0] = 0; sindices[1]=0;
                    }
                }

                Console.WriteLine(sindices.Min() +ans);

            }
        }
    }
}
