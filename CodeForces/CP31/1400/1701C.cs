namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1701C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,m) = (arr[0], arr[1]);

                var scheds = new int[n];

                var a = Console.ReadLine()!.Split(' ');

                foreach (var ai in a)
                {
                    var ain = int.Parse(ai);
                    scheds[ain - 1]++;
                }

                var start = (int)Math.Ceiling((double)m/n);
                var end = (int)Math.Ceiling((double)2 * m / n);
                var mid=(start+end)/2;

                while (start < end)
                {
                    var curcount = 0;
                    foreach(var si in scheds)
                    {
                        if(si<=mid)
                        {
                            curcount += si + (mid - si) / 2;
                        }
                        else
                        {
                            curcount += mid;
                        }
                    }

                    if (curcount >= m) end = mid;
                    else start = mid + 1;

                    mid = (start + end) / 2;
                }

                Console.WriteLine(mid);
            }
        }
    }
}
