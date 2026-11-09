namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1907E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            int[] dp = [1, 3, 6, 10, 15, 21, 28, 36, 45, 55];

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var ans = 1L;

                while(n > 0)
                {
                    var dig = n % 10;
                    n /= 10;
                    ans *= dp[dig];
                }

                Console.WriteLine(ans);
            }
        }
    }
}
