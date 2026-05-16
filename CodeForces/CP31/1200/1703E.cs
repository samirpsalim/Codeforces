namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1703E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                int[][] a = new int[n][];

                for(int j = 0; j < n; j++)
                {
                    a[j] = Console.ReadLine()!.Select(ai=> ai-48).ToArray();
                }

                var ans = 0;

                for(int j = 0;j < n-1-j; j++)
                {
                    for (int k = 0; k <= n - 1 - k; k++)
                    {
                        var ones = a[j][k] + a[k][n-1-j] + a[n-1-j][n-1-k] + a[n-1-k][j];

                        ans += ones <= 2 ? ones : 4 - ones;
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
