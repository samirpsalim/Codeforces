namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1808B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, m) = (arr[0], arr[1]);

                var c = new int[m][];

                for(int j =0; j < m; j++)
                {
                    c[j] = new int[n];
                }

                for(int j = 0; j < n; j++)
                {
                    var cj = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                    for(int k = 0; k < m; k++)
                    {
                        c[k][j] = cj[k];
                    }
                }

                var ans = 0L;

                foreach(var ci in c)
                {
                    Array.Sort(ci);

                    for(int j =1; j < n; j++)
                    {
                        ans += (long)j*(n - j) *(ci[j] - ci[j - 1]);
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
