namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1312B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var ans = Console.ReadLine()!.Split(' ').Select(int.Parse).OrderDescending().ToArray();

                Console.WriteLine(string.Join(" ", ans));
            }
        }
    }
}
