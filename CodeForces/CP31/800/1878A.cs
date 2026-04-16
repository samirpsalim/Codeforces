namespace Leetcode.CodeForces.CP31._800
{
    internal class _1878A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var ints = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (ints[0], ints[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(a.Contains(k) ? "YES" : "NO");
            }
        }
    }
}
