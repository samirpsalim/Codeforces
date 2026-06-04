namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1931D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,x,y) = (arr[0], arr[1],arr[2]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var dict = new Dictionary<int, Dictionary<int,int>>();
                var ys = new HashSet<int>();

                foreach(var ai in a)
                {
                    var xmod = ai % x;
                    var ymod = ai%y;

                    if(!dict.ContainsKey(ymod))
                    {
                        dict[ymod] = new();
                    }

                    if (dict[ymod].ContainsKey(xmod)) dict[ymod][xmod]++;
                    else dict[ymod][xmod]=1;

                    ys.Add(ymod);

                }

                var ans = 0L;

                foreach(var j in ys)
                {
                    var xdict = dict[j];

                    if (xdict.ContainsKey(0)) 
                        ans += (long)xdict[0] * (xdict[0] - 1) / 2;

                    if (x%2==0 && xdict.ContainsKey(x/2))
                        ans += (long)xdict[x/2] * (xdict[x/2] - 1) / 2;

                    foreach(var k in xdict.Keys)
                    {
                        if(2*k<x && xdict.ContainsKey(x-k))
                        ans += (long)xdict[k] * xdict[x - k];
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
