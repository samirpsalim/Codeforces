namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1776L
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            string s = Console.ReadLine()!;

            var pluscount = s.Count(c => c == '+');
            var minuscount = n - pluscount;

            var q = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < q; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (a, b) = (arr[0], arr[1]);

                if (a == b && minuscount != pluscount)
                {
                    Console.WriteLine("NO");
                    continue;
                }
                else if (pluscount == minuscount)
                {
                    Console.WriteLine("YES");
                    continue ;
                }

                if (a > b) (a, b) = (b, a);

                var minval = (long)a * (pluscount - minuscount);
                var diff = b - a;
                if ((-1 * minval) % diff != 0)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                var subcount = (-1 * minval) / diff;

                if (-1 * minuscount > subcount || pluscount < subcount)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                Console.WriteLine("YES");
            }
        }
    }
}
