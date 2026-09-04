namespace Leetcode.CodeForces.CP31._1400
{
    internal record Segment(int beg, int end);

    internal class _1907D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var segs = new Segment[n];
                var max = 0;

                for (int j = 0; j < n; j++)
                {
                    var inpseg =Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                    var curseg = new Segment(inpseg[0], inpseg[1]);

                    segs[j] = curseg;

                    if(curseg.beg>max) max = curseg.beg;
                }

                Console.WriteLine(MinMobileRange(segs,0,max));
            }
        }

        private static int MinMobileRange(Segment[] segs, int start, int end)
        {
            if (start == end) return start;

            var mid = (start + end)/2;

            if(CanReach(segs, mid)) return MinMobileRange(segs, start, mid);
            else return MinMobileRange(segs,mid+1,end);
        }

        private static bool CanReach(Segment[] segs, int range)
        {
            var currange = (0, 0);

            foreach (var seg in segs)
            {
                currange.Item1 -= range;
                currange.Item2 += range;

                if(currange.Item1 >seg.end || currange.Item2 <seg.beg)
                {
                    return false;
                }
                currange.Item1 = Math.Max(currange.Item1,seg.beg);
                currange.Item2 = Math.Min(currange.Item2,seg.end);
            }
            return true;
        }
    }
}
