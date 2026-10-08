
namespace Leetcode.CodeForces.CP31._1400
{
    internal class _414B
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n,k) = (arr[0],arr[1]);

            var ans = k switch
            {
                1 => n,
                2 => Enumerable.Range(1,n).Select(i=>n/i).Sum(),
                _ => GetResult(n,k)
            };

            Console.WriteLine(ans);
        }

        private static int GetResult(int n, int k)
        {
            var dp = new int[2][];

            dp[0] = new int[n];
            dp[1] = new int[n];

            for(int i=2; i<k; i++)
            {
                for(int j=0; j<n; j++)
                {
                    dp[i % 2][j] = 0;
                    
                    for(int l=j; l<n; l+=(j+1))
                    {
                        if (i == 2) dp[i % 2][j] = (dp[i % 2][j] + (n / (l+1))) % 1000000007;
                        else dp[i % 2][j] = (dp[i % 2][j] + dp[(i - 1) % 2][l]) % 1000000007;
                    }
                }
            }

            return dp[(k-1)%2].Aggregate((cursum,dpi) => (cursum+dpi)% 1000000007);
        }
    }
}
