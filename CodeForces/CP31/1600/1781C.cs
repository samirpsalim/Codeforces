namespace Leetcode.CodeForces.CP31._1600
{
    internal class CharCount
    {
        public CharCount(char c, int count) 
        { 
            this.C = c;
            this.Count = count;
        }

        public char C {  get; set; }
        public int Count { get; set; }
    }

    internal class CharCountComparer : IComparer<CharCount>
    {
        public int Compare(CharCount x, CharCount y)
        {
            if(x.Count != y.Count) return y.Count - x.Count;

            return y.C-x.C;
        }
    }

    internal class _1781C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                string s = Console.ReadLine()!;

                var freq = new CharCount[26];

                for (int j = 0; j < 26; j++) freq[j] = new((char)('a' + j), 0);

                for (int j = 0; j < n; j++) freq[s[j] - 'a'].Count++;

                Array.Sort(freq, new CharCountComparer());

                var best_j = 1;
                var leastops = n;

                for (int j = 1; j<=26;j++)
                {
                    if (n % j != 0) continue;

                    var unchanged = 0;

                    for (int k = 0; k<j; k++) unchanged += Math.Min(freq[k].Count, n / j);

                    if(n-unchanged<leastops)
                    {
                        leastops = n-unchanged;
                        best_j = j;
                    }
                }

                var excess = new Dictionary<char, int>();
                var subs = new List<CharCount>();
                var indCount = n/best_j;

                var validEntries = new HashSet<char>();

                for (int j = 0; j < best_j; j++)
                {
                    if (freq[j].Count > indCount) excess[freq[j].C] = freq[j].Count - indCount;
                    else if(freq[j].Count < indCount) subs.Add(new CharCount(freq[j].C, indCount - freq[j].Count));
                    validEntries.Add(freq[j].C);
                }

                var ansArr = new char[n];

                var subidx = 0;

                for(int j=0; j<n; j++)
                {
                    var exsVal = excess.TryGetValue(s[j], out var ex) ? ex : 0;

                    if (exsVal > 0)
                    {
                        ansArr[j] = subs[subidx].C;

                        subs[subidx].Count--;
                        excess[s[j]]--;

                        if (subs[subidx].Count == 0) subidx++;                       
                    }
                    else if(!validEntries.Contains(s[j]))
                    {
                        ansArr[j] = subs[subidx].C;

                        subs[subidx].Count--;

                        if (subs[subidx].Count == 0) subidx++;
                    }
                    else
                    {
                        ansArr[j] = s[j];
                    }
                }

                Console.WriteLine(leastops);
                Console.WriteLine(new string(ansArr));
            }
        }
    }
}
