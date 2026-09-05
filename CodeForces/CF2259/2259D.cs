using System.Text;

namespace Leetcode.CodeForces.CF2259
{
    internal class _2259D
    {
        static void Solve(string[] args)
        {
            var t=int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var zerocount = a.AsSpan().Count(0);

                if(zerocount ==1)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    var curzerocount = 0;
                    var ans = new StringBuilder(n);

                    for(int j=0; j<n; j++)
                    {
                        if (a[j] > 0)
                        {
                            ans.Append("A");
                        }
                        else
                        {
                            if (curzerocount % 2 == 0) ans.Append("B");
                            else ans.Append("C");
                            curzerocount++;
                        }
                    }

                    Console.WriteLine("YES");
                    Console.WriteLine(ans.ToString());
                }
            }
        }
    }
}
