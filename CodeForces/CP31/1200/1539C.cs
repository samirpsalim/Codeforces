namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1539C
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

            var (n, k, x) = (arr[0], arr[1], arr[2]);

            var a = Console.ReadLine()!.Split(' ').Select(long.Parse).Order().ToArray();

            var used = 0L;
            var filled = 0L;
            var gaplist = new List<long>();

            for(var i = 1; i < n; i++)
            {
                if (a[i] - a[i-1] >x)
                {
                    gaplist.Add((a[i] - a[i - 1]-1)/x);
                }
            }

            gaplist.Sort();

            for(var i = 0; i < gaplist.Count; i++)
            {
                if (used + gaplist[i] <=k)
                {
                    used += gaplist[i];
                    filled++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(1 + gaplist.Count - filled);
        }
    }
}
