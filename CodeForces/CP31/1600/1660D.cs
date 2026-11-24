namespace Leetcode.CodeForces.CP31._1600
{
    internal record struct ProdSegment(int start, int end, bool isPositive, int twoCount);

    internal class _1660D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var start = 0;
                var twoCount = 0;
                var isPositive = true;

                var segs = new List<ProdSegment>();

                for (int j = 0; j < n; j++)
                {
                    if (a[j] == 0)
                    {
                        if (start != j) segs.Add(new ProdSegment(start, j - 1, isPositive, twoCount));
                        start = j + 1;
                        twoCount = 0;
                        isPositive = true;
                    }
                    else
                    {
                        if (a[j] < 0) isPositive = !isPositive;
                        if (a[j] * a[j] == 4) twoCount++;
                    }
                }

                if (start != n) segs.Add(new ProdSegment(start, n - 1, isPositive, twoCount));

                var best = new ProdSegment(n, n, true, 0);

                foreach (var seg in segs)
                {
                    if (seg.isPositive)
                    {
                        if (seg.twoCount > best.twoCount) best = seg;
                        continue;
                    }

                    if (seg.twoCount <= best.twoCount) continue;

                    var curstart = seg.start;
                    var losingtwos = a[curstart] * a[curstart] == 4 ? 1 : 0;
                    while (curstart <= seg.end && a[curstart] > 0)
                    {
                        curstart++;
                        if (curstart <= seg.end) if (a[curstart] * a[curstart] == 4) losingtwos++;
                    }

                    if (curstart < seg.end && seg.twoCount - losingtwos > best.twoCount)
                    {
                        best = new ProdSegment(curstart + 1, seg.end, true, seg.twoCount - losingtwos);
                    }

                    var curend = seg.end;
                    losingtwos = a[curend] * a[curend] == 4 ? 1 : 0;
                    while (curend >= seg.start && a[curend] > 0)
                    {
                        curend--;
                        if (curend >= seg.start) if (a[curend] * a[curend] == 4) losingtwos++;
                    }

                    if (curend > seg.start && seg.twoCount - losingtwos > best.twoCount)
                    {
                        best = new ProdSegment(seg.start, curend-1, true, seg.twoCount - losingtwos);
                    }
                }

                Console.WriteLine($"{best.start} {(best.end ==n ? 0 : n-1-best.end)}");
            }
        }
    }
}
