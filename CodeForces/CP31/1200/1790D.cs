namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1790D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                var ans = 0;
                var last = 0;
                var active = 0;
                var curactive = 0;

                foreach (var ai in a)
                {
                    if(last == 0)
                    {
                        curactive++;
                        last = ai;
                        continue;
                    }

                    if (ai == last)
                    {
                        curactive++;
                        continue;
                    }

                    if(ai == last+1)
                    {
                        if(curactive < active)
                        {
                            ans += active - curactive;
                        }
                        active = curactive;
                        last = ai;
                        curactive = 1;

                        continue;
                    }

                    ans += Math.Max(active,curactive);
                    active = 0;
                    curactive = 1;
                    last = ai;
                }

                Console.WriteLine(ans+Math.Max(curactive, active));
            }
        }
    }
}