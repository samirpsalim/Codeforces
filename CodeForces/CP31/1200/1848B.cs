namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1848B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            var posdict = new Dictionary<int, int>();
            var lendict = new Dictionary<int, List<int>>();

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                var c = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                for(int j =0; j < n; j++)
                {
                    if (posdict.TryGetValue(c[j], out var lastpos))
                    {
                        lendict[c[j]].Add(j-lastpos);
                    }
                    else
                    {
                        lendict[c[j]] = [j+1];
                    }
                    posdict[c[j]] = j;
                }

                foreach(var pos in posdict)
                {
                    lendict[pos.Key].Add(n-pos.Value);
                }

                var ans = n+1;

                foreach(var lens in lendict.Values)
                {
                    var toptwo = lens.OrderDescending().Take(2).ToList();

                    var topsplit = (toptwo[0] + 1) / 2;

                    var topmax = Math.Max(topsplit, toptwo[1]);

                    ans = Math.Min(ans, topmax-1);
                }

                Console.WriteLine(ans);

                posdict.Clear();
                lendict.Clear();
            }
        }
    }
}
