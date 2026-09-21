namespace Leetcode.CodeForces.CP31._1400
{
    internal class Entry
    {
        public Entry(int count, int rowsum, int colsum, SortedDictionary<int, int> Rows, SortedDictionary<int, int> Cols)
        {
            this.Count = count;
            this.RowSum = rowsum;
            this.ColSum = colsum;
            this.Rows = Rows;
            this.Cols = Cols;
        }

        public int Count { get; set; }
        public long RowSum { get; set; }
        public long ColSum { get; set; }
        public SortedDictionary<int,int> Rows { get; set; }
        public SortedDictionary<int, int> Cols { get; set; }
    }

    internal class _1648A
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n,m) = (arr[0],arr[1]);

            var elems = new Dictionary<int, Entry>();

            for (int i = 0; i < n; i++)
            {
                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j<m; j++)
                {
                    if (elems.ContainsKey(arr[j]))
                    {
                        var curentry = elems[arr[j]];

                        curentry.Count++;
                        curentry.RowSum += i;
                        curentry.ColSum += j;

                        if (curentry.Rows.ContainsKey(i)) curentry.Rows[i]++;
                        else curentry.Rows[i] = 1;

                        if (curentry.Cols.ContainsKey(j)) curentry.Cols[j]++;
                        else curentry.Cols[j] = 1;
                    }
                    else
                    {
                        var curcols = new SortedDictionary<int, int>();
                        curcols[j] = 1;
                        var currows = new SortedDictionary<int, int>();
                        currows[i] = 1;
                        var curentry = new Entry(1, i, j, currows, curcols);

                        elems[arr[j]] = curentry;
                    }
                }
            }

            var ans = 0L;

            foreach (var elem in elems)
            {
                var curentry = elem.Value;

                var curcount = curentry.Count;
                var cursum = curentry.ColSum;
                var curdict = curentry.Cols;

                foreach(var kv in curdict)
                {
                    var curval = kv.Value;
                    var j = kv.Key;
                    cursum -= (long)curval * j;
                    curcount -= curval;

                    ans += curval * (cursum - (long)j * curcount);
                }

                curcount = curentry.Count;
                cursum = curentry.RowSum;
                curdict = curentry.Rows;

                foreach (var kv in curdict)
                {
                    var curval = kv.Value;
                    var j = kv.Key;
                    cursum -= (long)curval * j;
                    curcount -= curval;

                    ans += curval * (cursum - (long)j * curcount);
                }
            }

            Console.WriteLine(ans);
        }
    }
}
