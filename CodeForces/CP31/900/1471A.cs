using System.Xml;

namespace Leetcode.CodeForces.CP31._900
{
    internal class _1471A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, x) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                long sum = 0;
                long maxbeauty = 0;

                foreach(var ai in a)
                {
                    sum += ai;
                    maxbeauty += (ai + x - 1) / x;
                }

                Console.WriteLine($"{(sum+x-1)/x} {maxbeauty}");

            }
        }
    }
}
