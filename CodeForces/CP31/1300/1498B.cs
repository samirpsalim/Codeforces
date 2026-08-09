namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1498B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, w) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).GroupBy(ai => ai)
                        .OrderByDescending(g=> g.Key).ToDictionary(g=> g.Key,g=> g.Count()).ToArray();

                var h = 0;
                while (n > 0)
                {
                    var curgap = w;
                    var curpos = 0;
                    while(curpos < a.Length)
                    {
                        var curkvp = a[curpos];
                        if (curgap >= curkvp.Key && curkvp.Value >0)
                        {
                            a[curpos] = new KeyValuePair<int, int>(curkvp.Key, curkvp.Value-1);
                            curgap -= curkvp.Key;
                            n--;
                        }
                        else
                        {
                            curpos++;
                        }
                    }
                    if (curgap < w) h++;
                }

                Console.WriteLine(h);
            }
        }
    }
}
