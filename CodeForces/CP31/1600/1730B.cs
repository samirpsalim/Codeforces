namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1730B
    {
        static void Solve(string[] args)
        {
            var T = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < T; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var x = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var t = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var order = Enumerable.Range(0, n).Select(j => new Tuple<int, int>(x[j], t[j])).OrderBy(tup => tup.Item1);

                var j = 0;
                foreach(var tup in order)
                {
                    x[j] = tup.Item1;
                    t[j] = tup.Item2;
                    j++;
                }

                var p = new int[n];
                var s = new int[n];

                p[0] = t[0] - x[0];
                for (j = 1; j < n; j++) p[j] = Math.Max(p[j - 1], t[j] - x[j]);

                s[n-1] = t[n-1] + x[n-1];
                for(j= n-2; j >=0; j--) s[j] = Math.Max(s[j+1], t[j] + x[j]);

                double xans = x[0];
                double curd = s[0]-xans;

                if (p[n - 1] + x[n-1] < curd)
                {
                    xans = x[n - 1];
                    curd = p[n - 1] + xans;
                }

                for(j=0; j < n-1; j++)
                {
                    var pLeft = p[j] + x[j] > s[j+1]-x[j];
                    var pRight = p[j] + x[j+1] > s[j+1] - x[j+1];

                    if(pLeft && pRight)
                    {
                        var d = p[j] + x[j];
                        var curx = x[j];
                        if (d < curd)
                        {
                            curd = d;
                            xans = curx;
                        }
                    }
                    else if(!pLeft && !pRight)
                    {
                        var d = s[j+1] - x[j+1];
                        var curx = x[j+1];
                        if (d < curd)
                        {
                            curd = d;
                            xans = curx;
                        }
                    }
                    else
                    {
                        var curx = (double)(s[j + 1] - p[j]) / 2;
                        var d = p[j] + curx;
                        if (d < curd)
                        {
                            curd = d;
                            xans = curx;
                        }
                    }
                }

                Console.WriteLine(xans);
            }
        }
    }
}
