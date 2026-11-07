namespace Leetcode.CodeForces.CF2280
{
    internal class _2280B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                Console.WriteLine($"? {1} {n}");
                var in1 = int.Parse(Console.ReadLine()!);

                if (in1 == 0)
                {
                    Console.WriteLine("! NO");
                    continue;
                }

                Console.WriteLine($"? {1} {in1}");
                var in2 = int.Parse(Console.ReadLine()!);

                Console.WriteLine(in1==in2 ? "! NO": "! YES");
            }
        }
    }
}
