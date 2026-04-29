namespace Leetcode.CodeForces.CP31._1000
{
    internal class SizeTracker 
    {
        public SizeTracker(int index, List<int> positions)
        {
            nextindex = index;
            occurances = positions;
        }

        public int nextindex { get; set; }
        public List<int> occurances { get; set; }
    };
    internal class _1691B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var sizedict = new Dictionary<int,SizeTracker>();

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var s = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    if(sizedict.ContainsKey(s[j]))
                    {
                        sizedict[s[j]].occurances.Add(j+1);
                    }
                    else
                    {
                        var entry = new SizeTracker(1, [j+1]);
                        sizedict[s[j]] = entry;
                    }
                }

                var impossible = sizedict.Values.Select(v=> v.occurances.Count).Any(x=>x==1);
                if(impossible)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    var ans = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        var entry = sizedict[s[j]];
                        ans[j] = entry.occurances[entry.nextindex];
                        entry.nextindex = (entry.nextindex + 1) % entry.occurances.Count;
                    }

                    Console.WriteLine(string.Join(' ',ans));
                }

                sizedict.Clear();
            }

        }
    }
}
