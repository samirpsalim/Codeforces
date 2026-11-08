namespace Leetcode.CodeForces.CP31._1500
{
    internal class SwitchStatus
    {
        public SwitchStatus(int start, int end)
        {
            Start = start; End = end;
        }

        internal int Start { get; set; }
        internal int End { get; set; }
    }

    internal class _276C
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n, q) = (arr[0], arr[1]);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var numset = new SortedSet<int>();

            var switchlog = new Dictionary<int,SwitchStatus>();

            for (int i = 0; i < q; i++)
            {
                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var (l, r) = (arr[0]-1, arr[1]-1);

                numset.Add(l);
                numset.Add(r);

                if (!switchlog.ContainsKey(l)) switchlog[l] = new SwitchStatus(0, 0);
                if (!switchlog.ContainsKey(r)) switchlog[r] = new SwitchStatus(0, 0);

                switchlog[l].Start++;
                switchlog[r].End++;
            }

            var numarr = numset.ToArray();
            var arridx = 0;
            var opencount = 0;

            var b = new int[n];

            for (int i = 0; i<n; i++)
            {
                if (arridx == numarr.Length)
                {
                    b[i] = opencount;
                    continue;
                }

                if (numarr[arridx] ==i)
                {
                    opencount += switchlog[i].Start;
                    b[i]=opencount;
                    opencount -= switchlog[i].End;
                    arridx++;
                    continue;
                }
                b[i] = opencount;
            }

            Array.Sort(b);
            Array.Sort(a);

            var ans = 0L;

            for (int i = 0;i<n;i++)
            {
                ans += (long)a[i] * b[i];
            }

            Console.WriteLine(ans);
        }
    }
}
