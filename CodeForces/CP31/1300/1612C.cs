namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1612C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (k, x) = ((int)arr[0], arr[1]);

                var start = 1;
                var end = 2 * k - 1;

                var mid = start +(end-start) / 2;

                while(start < end)
                {
                    var prev = Calc(mid - 1,k);
                    var cur = Calc(mid,k);
                    if (prev < x && cur >= x)
                    {
                        break;
                    }
                    else if(cur <x)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                    mid = start + (end - start) / 2;
                }

                Console.WriteLine(mid);
            }
        }

        private static long Calc(long pos, long k)
        {
            if (pos <= k)
            {
                return pos * (pos + 1) / 2;
            }

            return k * k - (2 * k - 1 - pos) * (2 * k - pos) / 2;
        }
    }
}
