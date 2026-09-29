namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1350B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var s = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var dp = new int[n];

                for(int j = 1; 2*j <= n; j++)
                {
                    var pos = j-1;
                    for(int k = pos+j; k<n; k+=j)
                    {
                        if (s[k] > s[pos])
                        {
                            dp[k] = Math.Max(dp[k], dp[pos]+1);
                        }
                    }
                }

                Console.WriteLine(dp.Max()+1);
            }
        }
    }
}
