namespace Leetcode.CodeForces.CF2217
{
    internal class _2217A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var inputs = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var n = inputs[0];
                var k = inputs[1];

                var asum = Console.ReadLine()!.Split(' ').Select(int.Parse).Sum();

                Console.WriteLine(n * k % 2 == 0 || asum % 2 == 1 ? "YES" : "NO");

            }
        }
    }
}
