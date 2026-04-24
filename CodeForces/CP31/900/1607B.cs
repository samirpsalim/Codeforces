namespace Leetcode.CodeForces.CP31._900
{
    internal class _1607B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (x0, n) = (arr[0], arr[1]);

                var ans = (n % 4) switch
                {
                    0 => x0,
                    1 => x0 % 2 == 0 ? x0 - n : x0 +n,
                    2 => x0 % 2 == 0 ? x0+1 : x0 -1,
                    3=> x0 % 2 == 0 ? x0 + n +1 : x0 - n-1,
                    _=> -1
                };

                Console.WriteLine(ans);

            }
        }
    }
}
