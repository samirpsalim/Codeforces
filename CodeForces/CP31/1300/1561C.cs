namespace Leetcode.CodeForces.CP31._1300
{
    internal record Cave(long minstart, long k);

    internal class CaveComparer : IComparer<Cave>
    {
        public int Compare(Cave? x, Cave? y)
        {
            return x.minstart < y.minstart ? -1 : x.minstart == y.minstart ? 0 : 1;
        }
    }

    internal class _1561C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var caves = new Cave[n];

                for(int j = 0; j < n; j++)
                {
                    var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
                    var k = arr[0];
                    var a = arr.AsSpan(1);

                    var minstart = 2L;

                    for(int l=0; l< k; l++)
                    {
                        if (a[l] + 1 - l > minstart) minstart = a[l] + 1 - l;
                    }
                    caves[j] = new Cave(minstart, k);
                }

                Array.Sort(caves, new CaveComparer());

                var killcount = 0L;
                var ans = caves[0].minstart;
                foreach (var cave in caves)
                {
                    if(ans+ killcount < cave.minstart)
                    {
                        ans = cave.minstart - killcount;
                    }
                    killcount += cave.k;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
