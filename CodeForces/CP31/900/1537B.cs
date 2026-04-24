namespace Leetcode.CodeForces.CP31._900
{
    internal class _1537B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int I = 0; I < t; I++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, m, i, j) = (arr[0], arr[1], arr[2], arr[3]);

                Console.WriteLine($"1 1 {n} {m}");
            }
        }
    }
}
