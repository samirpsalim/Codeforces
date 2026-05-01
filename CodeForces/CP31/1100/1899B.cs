namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1899B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var prefsums = new long[n];
                var ans = 0L;

                prefsums[0] = a[0];

                for(int j = 1; j < n; j++)
                {
                    prefsums[j] = prefsums[j-1]+ a[j];
                }

                for(int j = 1;j <=n/2; j++)
                {
                    if(n%j!=0)
                    {
                        continue;
                    }
                    var min = prefsums[j-1];
                    var max = prefsums[j-1];

                    for(int k=1; k<n/j; k++)
                    {
                        var cursum = prefsums[(k+1)*j-1]-prefsums[k*j-1];
                        max = Math.Max(max, cursum);
                        min = Math.Min(min, cursum);
                    }
                    ans = Math.Max(ans, max-min);

                }

                Console.WriteLine(ans);

            }
        }
    }
}
