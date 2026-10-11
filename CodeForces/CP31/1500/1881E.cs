namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1881E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var dp = new int[n + 1];

                for (int j = n - 1; j >= 0; j--)
                {
                    if (j + a[j] + 1 > n) dp[j] = dp[j + 1] + 1;
                    else dp[j] = Math.Min(dp[j + 1] + 1, dp[j + a[j] + 1]);
                }

                Console.WriteLine(dp[0]);
            }
        }
    }
}
