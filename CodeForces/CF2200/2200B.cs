

namespace Leetcode.CodeForces.CF2200
{
    internal class _2200B
    {
        static void Solve(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine(GetMinimumElementLeft(a.AsSpan(),n));
            }
        }

        private static int GetMinimumElementLeft(Span<int> span, int size)
        {
            if (size == 1)
                return 1;

            for(int i = 1; i < size; i++)
            {
                if (span[i] < span[i - 1])
                    return 1;
            }

            return size;
        }
    }
}
