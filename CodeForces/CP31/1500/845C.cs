namespace Leetcode.CodeForces.CP31._1500
{
    internal class ChangeLog
    {
        public ChangeLog(int start, int end)
        {
            Start = start; End = end;
        }

        internal int Start { get; set; }
        internal int End { get; set; }
    }

    

    internal class _845C
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var sortedSet = new SortedSet<int>();
            var logdict = new Dictionary<int, ChangeLog>();

            for (int i = 0; i < n; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (l, r) = (arr[0], arr[1]);

                sortedSet.Add(l);
                sortedSet.Add(r);

                if (!logdict.ContainsKey(l)) logdict[l] = new ChangeLog(0, 0);
                if (!logdict.ContainsKey(r)) logdict[r] = new ChangeLog(0, 0);

                logdict[l].Start++;
                logdict[r].End++;
            }

            var ans = "YES";
            var open = 0;

            foreach (var ts in sortedSet)
            {
                var log = logdict[ts];

                open += log.Start;

                if(open >2)
                {
                    ans = "NO";
                    break;
                }

                open -=log.End;
            }

            Console.WriteLine(ans);
        }
    }
}
