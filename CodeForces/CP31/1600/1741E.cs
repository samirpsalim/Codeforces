namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1741E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var dp = new bool[n];
                
                for(int j = 0; j < n; j++)
                {
                    var isRightClearable = (j == 0 || dp[j - 1]) && (j+a[j]<n);
                    if(isRightClearable)
                    {
                        dp[j+a[j]] = true;
                    }

                    var isLeftClearable = ((j-a[j]-1) ==-1) || (j-a[j]-1 >=0 && dp[j-a[j]-1]);
                    if(isLeftClearable)
                    {
                        dp[j] = true;
                    }
                }

                Console.WriteLine(dp[n-1] ? "YES" : "NO");
            }
        }
    }
}
