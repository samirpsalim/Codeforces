namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1466D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var w = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var degs = new int[n];

                for (int j = 0; j < n - 1; j++)
                {
                    var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                    degs[arr[0] - 1]++;
                    degs[arr[1] - 1]++;
                }

                var idxs = Enumerable.Range(0, n).OrderByDescending(idx => w[idx]).ToArray();

                var ans = new long[n - 1];
                ans[0] = w.Select(wi => (long)wi).Sum();

                var j2 = 1;
                var idxpos = 0;

                while (j2 < n - 1)
                {
                    var idx = idxs[idxpos];
                    var deg = degs[idx];
                    var wj = w[idx];

                    if (deg < 2)
                    {
                        idxpos++;
                    }
                    else
                    {
                        ans[j2] += ans[j2 - 1] + wj;
                        degs[idx]--;
                        j2++;
                    }
                }

                Console.WriteLine(string.Join(' ', ans));
            }
        }
    }
}
