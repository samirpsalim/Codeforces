using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2021
{
    internal class _2021B
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine()!.Split(' ');

                var n = int.Parse(input[0]);
                var x = long.Parse(input[1]);

                var a = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var moddict = a.GroupBy(ai => ai % x).
                    ToDictionary(g => g.Key, g => g.Select(ai => (ai - g.Key) / x).
                                        Order().ToArray());

                long min = long.MaxValue;

                for(int j=0; j < x; j++)
                {
                    if (min < j) break;
                    var mex = SubMex(x, j, moddict);
                    if(mex<min) min = mex;
                }

                Console.WriteLine(min);

            }
        }

        private static long SubMex(long x, long key, Dictionary<long,long[]> dict)
        {
            if (!dict.ContainsKey(key)) return key;

            var list = dict[key];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > i) return (long)i * x + key;
            }
            return x * list.Length + key;
        }
    }
}
