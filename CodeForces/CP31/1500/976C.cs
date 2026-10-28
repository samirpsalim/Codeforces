namespace Leetcode.CodeForces.CP31._1500
{
    internal class _976C
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var segs = new (int, int)[n];

            for (int i = 0; i < n; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                segs[i] = (arr[0],arr[1]);
            }

            var sortsegs = segs.Select((seg,idx)=>(seg.Item1,seg.Item2,idx+1)).OrderBy(seg=>seg.Item1)
                            .ThenByDescending(seg=> seg.Item2).ToArray();

            var ans = (-1,-1);
            var max = sortsegs[0].Item2;
            var maxseg = sortsegs[0].Item3;

            for (int i = 1;i < n;i++)
            {
                if (sortsegs[i].Item2<=max)
                {
                    ans = (maxseg, sortsegs[i].Item3);
                    break;
                }
                else
                {
                    max= sortsegs[i].Item2;
                }
            }

            Console.WriteLine($"{ans.Item2} {ans.Item1}");
        }
    }
}
