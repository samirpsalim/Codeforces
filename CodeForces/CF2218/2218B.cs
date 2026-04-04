namespace Leetcode.CodeForces.CF2218
{
    internal class _2218B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine(2 * a.Max() - a.Sum());
            }
        }
    }
}