using System.Security.Cryptography;

namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1715B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse)
                            .ToArray();

                var (n,k,b,s) = (arr[0], arr[1], arr[2],arr[3]);

                var min = b * k;
                var max = b*k + n*(k-1);

                if(s>max || s<min)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                var diff = s - min;
                var ans = new long[n];

                for(int j=0; j<n; j++)
                {
                    var curdiff = Math.Min(diff, k-1);
                    ans[j] = curdiff;
                    diff-=curdiff;
                    if(diff==0) break;
                }
                ans[0] += min;

                Console.WriteLine(string.Join(' ',ans));
            }
        }
    }
}
