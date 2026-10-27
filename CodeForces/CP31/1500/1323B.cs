namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1323B
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n, m, k) = (arr[0], arr[1], arr[2]);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var adict = new Dictionary<int, int>();

            var curlen = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] == 1) curlen++;
                else
                {
                    if(curlen>0)
                    {
                        if (adict.ContainsKey(curlen)) adict[curlen]++;
                        else adict[curlen] = 1;
                    }

                    curlen = 0;
                }
            }

            if (a[n - 1] == 1)
            {
                if (adict.ContainsKey(curlen)) adict[curlen]++;
                else adict[curlen] = 1;
            }
            curlen = 0;

            var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var bdict = new Dictionary<int, int>();

            for (int i = 0; i < m; i++)
            {
                if (b[i] == 1) curlen++;
                else
                {
                    if(curlen>0)
                    {
                        if (bdict.ContainsKey(curlen)) bdict[curlen]++;
                        else bdict[curlen] = 1;
                    }
                    curlen = 0;
                }
            }

            if (b[m - 1] == 1)
            {
                if (bdict.ContainsKey(curlen)) bdict[curlen]++;
                else bdict[curlen] = 1;
            }

            var ans = 0L;

            var alist = adict.ToArray();
            var blist = bdict.ToArray();

            for (int i = 0;i < alist.Length;i++)
            {
                var ai = alist[i];

                for(int j=0; j<blist.Length;j++)
                {
                    var bj = blist[j];

                    if(ai.Key*bj.Key<k) continue;

                    var comboval = 0L;

                    for(int i1=1; i1<=ai.Key;i1++)
                    {
                        if(k%i1!=0) continue;

                        var j1 = k / i1;

                        if(j1>bj.Key) continue;

                        var icount = ai.Key + 1 - i1;
                        var jcount = bj.Key + 1 - j1;
                        comboval += icount * jcount;
                    }

                    ans += comboval * ai.Value * bj.Value;
                    
                }
            }

            Console.WriteLine(ans);
        }
    }
}
