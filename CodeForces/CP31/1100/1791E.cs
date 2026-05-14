namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1791E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .Order().ToArray();

                var ans = n % 2 == 1 ? a[n - 1] : 0L;

                for(int j = 0; j < n/2; j++)
                {
                    ans += Math.Abs(a[2 * j] + a[2 * j + 1]);
                }

                Console.WriteLine(ans);
            }
        }
    }
}
