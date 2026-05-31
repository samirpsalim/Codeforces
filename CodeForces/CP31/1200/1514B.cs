namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1514B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                var ans = 1L;

                for (int j = 0; j < k; ++j)
                {
                    ans = (ans * n) % (1_000_000_007);
                }
                Console.WriteLine(ans);
            }
        }
    }
}
