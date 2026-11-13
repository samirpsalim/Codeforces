namespace Leetcode.CodeForces.CP31._1600
{
    internal record struct Segment(int l, int r);

    internal class _1843E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, m) = (arr[0], arr[1]);

                var segs = new Segment[m];

                for (int j = 0; j < m; j++)
                {
                    arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                    segs[j] = new Segment(arr[0], arr[1]);
                }

                var q = int.Parse(Console.ReadLine()!);
                var xarr = new int[q];

                for (int j = 0; j < q; j++)
                {
                    xarr[j] = int.Parse(Console.ReadLine()!);
                }

                var start = 1;
                var end = q + 1;
                var mid = (start + end) / 2;

                while(start<end)
                {
                    if (Check(n, xarr.AsSpan(0, mid), segs)) end = mid;
                    else start = mid + 1;

                    mid = (start + end) / 2;
                }

                Console.WriteLine(mid == q + 1 ? -1 : mid);
            }
        }

        private static bool Check(int n, Span<int> ones, Segment[] segs)
        {
            var onesSet = new HashSet<int>(ones.Length);
            foreach (var one in ones) onesSet.Add(one);

            var curval = 0;
            var a = new int[n+1];

            for (int i = 1; i <= n; i++)
            {
                if (onesSet.Contains(i))
                {
                    curval++;
                }

                a[i] = curval;
            }

            foreach (var seg in segs)
            {
                if (seg.r + 1 - seg.l < 2 * (a[seg.r] - a[seg.l-1])) return true;
            }
            return false;
        }
    }
}
