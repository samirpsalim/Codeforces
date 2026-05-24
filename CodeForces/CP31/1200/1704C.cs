namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1704C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,m) = (arr[0],arr[1]);

                long ans = m;

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                var segments = new int[m];

                for(int j=1; j<m; j++)
                {
                    segments[j - 1] = a[j] - a[j - 1]-1;
                }

                segments[m - 1] = n + a[0] - a[m - 1]-1;

                Array.Sort(segments);

                var prevclear = 0;

                for(int j=m-1; j >= 0; j--)
                {
                    var cur = Math.Max(0, segments[j]- prevclear);

                    if (cur > 1) cur--;
                    ans += segments[j] - cur;

                    prevclear += 4;
                }

                Console.WriteLine(ans);

            }
        }
    }
}
