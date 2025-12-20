using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2180
{
    internal class _2180C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; ++i)
            {
                var nums = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(Process(nums[0], nums[1]));
            }
        }

        private static string Process(int n, int k)
        {
            var ans = new StringBuilder();
            if(k%2 == 1)
            {
                for (int i = 0; i < k; ++i)
                {
                    ans.Append(n);
                    ans.Append(" ");
                }
                return ans.ToString();
            }

            var binstr = GetBinaryString(n, out var bitcount);

            for (int i = 0; i < k - bitcount; ++i)
            {
                ans.Append(n);
                ans.Append(" ");
            }

            var onesSeen = 0;
            int numlen = Math.Min(bitcount, k);
            var nums = new int[numlen];
            foreach(var x in binstr)
            {
                if (x == '1')
                {
                    for(int i =0; i<numlen;++i)
                    {
                        nums[i] = 2*nums[i] + (i==onesSeen%numlen ? 0 : 1);
                    }
                    onesSeen++;
                }
                else
                {
                    var end = onesSeen>=numlen?
                        2*(numlen/2) :onesSeen%2==0? onesSeen : onesSeen-1;
                    for (int i = 0; i < end; ++i)
                    {
                        nums[i] = 2 * nums[i] + 1;
                    }
                    for (int i = end; i < numlen; ++i)
                    {
                        nums[i] = 2 * nums[i];
                    }
                }

            }

            ans.Append(string.Join(" ", nums));
            return ans.ToString();
        }

        private static string GetBinaryString(int n, out int truecount)
        {
            truecount = 0;
            var st = new StringBuilder();
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    st.Insert(0, '1');
                    truecount++;
                }
                else st.Insert(0, '0');
                n >>= 1;
            }
            return st.ToString();
        }
    }
}
