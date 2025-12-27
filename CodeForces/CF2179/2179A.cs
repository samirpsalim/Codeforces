namespace Leetcode.CodeForces.CF2179
{
    internal class _2179A
    {
        static void Solve(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var inputs = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine(inputs[0] * inputs[1] + 1);
            }
        }
    }
}
