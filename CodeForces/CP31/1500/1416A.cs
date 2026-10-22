namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1416A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var idxs = new Dictionary<int, List<int>>();

                for (int j = 0; j < n; j++)
                {
                    if (idxs.ContainsKey(a[j])) idxs[a[j]].Add(j);
                    else idxs[a[j]] = [j];
                }

                var dp = new Dictionary<int,int>();

                foreach(var val in idxs.Keys)
                {
                    var poslst = idxs[val];

                    var gap = poslst[0] + 1;

                    for (int j = 1; j< poslst.Count;j++)
                    {
                        gap = Math.Max(gap, poslst[j] - poslst[j-1]);
                    }

                    gap = Math.Max(gap, n - poslst[poslst.Count - 1]);
                    dp[val] = gap;
                }

                var gapdict = dp.GroupBy(kv=> kv.Value).ToDictionary(g=> g.Key,
                               g=> g.MinBy(kv=> kv.Key).Key).OrderBy(kv=> kv.Key)
                               .ToArray();

                var bsarr = dp.OrderByDescending(kv=> kv.Value).ThenBy(kv=>kv.Key)
                            .Select(kv => kv.Key).Concat([-1]).ToArray();

                var ans = new int[n];
                var curidx = 0;

                for (int j = 0; j < n; j++)
                {
                    var prev = j==0? -1 : ans[j-1];

                    if(curidx== gapdict.Length)
                    {
                        ans[j] = prev;
                        continue;
                    }

                    if (gapdict[curidx].Key<=j+1)
                    {
                        ans[j] = prev!=-1? Math.Min(prev, gapdict[curidx].Value)
                                :gapdict[curidx].Value;
                        curidx++;
                    }
                    else
                    {
                        ans[j] = prev;
                    }
                }

                Console.WriteLine(string.Join(' ', ans));
            }
        }
    }
}
