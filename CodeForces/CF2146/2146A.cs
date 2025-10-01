using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2146
{
    internal class _2146A
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            Dictionary<int,int> elemswgrfreq = new Dictionary<int,int>();

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine());

                var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int ans = 0;

                elemswgrfreq[1] = 1;

                int currentcount = 1;

                for (int j = 1; j < n; j++)
                {
                    if (a[j] == a[j - 1]) currentcount++;
                    else currentcount = 1;

                    if (elemswgrfreq.ContainsKey(currentcount)) elemswgrfreq[currentcount]++;
                    else elemswgrfreq[currentcount] = 1;
                }

                foreach(var freq in elemswgrfreq.Keys)
                {
                    if(freq*elemswgrfreq[freq] >ans) ans = freq*elemswgrfreq[freq];

                    elemswgrfreq[freq] = 0;
                }

                Console.WriteLine(ans);

            }
        }
    }
}
