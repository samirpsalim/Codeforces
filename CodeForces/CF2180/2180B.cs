using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2180
{
    internal class _2180B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ');

                var ans = "";

                foreach(var s in a)
                {
                    ans = (ans+s).CompareTo(s+ans)<0 ? ans+s : s+ans;
                }

                Console.WriteLine(ans);

            }
        }
    }
}
