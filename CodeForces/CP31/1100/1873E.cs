namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1873E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, x) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var start = 1L;
                var end = (long)x +(long)a.Min();
                var h = (start+end+1)/2;

                while(start < end)
                {
                    var watercol = 0L;

                    foreach(var ai in a)
                    {
                        if (ai < h)
                        {
                            watercol += (h - ai);
                        }
                    }

                    if (watercol > x)
                    {
                        end = h - 1;
                    }
                    else
                    {
                        start = h;
                    }
                    h= (start+end+1)/2;
                }

                Console.WriteLine(start);
            }
        }
    }
}
