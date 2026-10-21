namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1418C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                if (n < 4)
                {
                    Console.WriteLine(a[0]);
                    continue;
                }

                var dp = new int[n];

                dp[n - 1] = a[n - 1];
                dp[n - 2] = a[n - 2];
                dp[n - 3] = a[n - 3];
                dp[n - 4] = a[n - 4] + (a.TakeLast(3).Sum() == 3 ? 1 : 0);

                for(int j=n-5;j>=0; j--)
                {
                    var dp2 = a[j] + dp[j + 2];
                    var dp3 = a[j] + dp[j + 3];
                    var dp4 = a[j] + a[j+1] + dp[j+4];

                    dp[j] = Math.Min(dp2, Math.Min(dp3,dp4));
                }

                Console.WriteLine(dp[0]);
            }
        }
    }
}
