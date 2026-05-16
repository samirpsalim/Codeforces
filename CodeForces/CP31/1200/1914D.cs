namespace Leetcode.CodeForces.CP31._1200
{
    internal record Day(int date, int friends);

    internal class _1914D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Select((ai,idx) => new Day(idx,ai))
                        .OrderByDescending(ai=> ai.friends).Take(3).ToArray();
                var b = Console.ReadLine()!.Split(' ').Select(int.Parse).Select((ai, idx) => new Day(idx, ai))
                        .OrderByDescending(ai => ai.friends).Take(3).ToArray();
                var c = Console.ReadLine()!.Split(' ').Select(int.Parse).Select((ai, idx) => new Day(idx, ai))
                        .OrderByDescending(ai => ai.friends).Take(3).ToArray();

                var ans = 0;

                foreach(var ai in a)
                {
                    foreach(var bi in b)
                    {
                        if (ai.date == bi.date)
                        {
                            continue;
                        }
                        foreach(var ci in c)
                        {
                            if (ai.date == ci.date || bi.date==ci.date)
                            {
                                continue;
                            }
                            ans = Math.Max(ans, ai.friends+bi.friends+ci.friends);

                        }

                    }
                }


                Console.WriteLine(ans);
            }
        }
    }
}
