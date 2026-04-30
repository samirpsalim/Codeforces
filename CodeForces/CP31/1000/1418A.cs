namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1418A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (x, y, k) = (arr[0], arr[1], arr[2]);

                var nom = (k * y + k - 1);
                var den = x - 1;

                var ans = k+ (nom/den) + (nom%den!=0 ? 1 : 0);

                Console.WriteLine(ans);
            }
        }
    }
}
