namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1659C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (n, a, b) = (arr[0], arr[1], arr[2]);

                var x = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var ans = b*x[0];
                var c = 0;

                for(int j=1; j<n; j++)
                {
                    if (a * (x[j-1]-c) > b* (x[j - 1] - c)*(n-j))
                    {
                        ans += b * (x[j] - c);
                    }
                    else
                    {
                        ans += a * (x[j-1] - c);
                        c = x[j - 1];
                        ans += b * (x[j] - c);
                    }
                }
                Console.WriteLine(ans);

            }
        }
    }
}
