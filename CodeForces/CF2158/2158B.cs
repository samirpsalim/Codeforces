using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2158
{
    internal class _2158B
    {
        static void Solve()
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var countdict = CountOccurences(a);

                Console.WriteLine(Process(countdict, n));

            }
        }

        private static int Process(Dictionary<int, int> countdict, int n)
        {
            var evenbuff = 0;
            var oddcount = 0;
            var evencount = 0;
            var basecount = 0;

            foreach(var i in countdict)
            {
                if (i.Value % 2 != 0)
                {
                    oddcount += i.Value;
                    basecount += 1;
                }
                else
                {
                    evencount++;
                    evenbuff+=i.Value-2;
                    basecount += 2;
                }
            }

            if(oddcount + evencount >=n)
            {
                return basecount;
            }
            var target =  n - oddcount - evencount;

            if (target % 2 == 1)
            {
                if (oddcount>0)
                {
                    target++;
                }
                else
                {
                    basecount -= 2;
                    target--;
                }
            }
            if(target<=evenbuff) 
            { 
                return basecount;
            }
            if (oddcount>0 && (n - oddcount - evencount) % 2 == 1)
            {
                target--;
            }
            return basecount - 2* (target-evenbuff);
        }

        private static Dictionary<int,int> CountOccurences(int[] a)
        {
            var dict = new Dictionary<int,int>();
            for (int i = 0; i < a.Length; ++i)
            {
                if (dict.ContainsKey(a[i])) dict[a[i]]++;
                else dict[a[i]] = 1;
            }
            return dict;
        }
    }
}
