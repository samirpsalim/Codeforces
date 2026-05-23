namespace Leetcode.CodeForces.CF2229
{
    internal class _2229A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var max = a.Max();
                var min = a.Min();

                Console.WriteLine((max+1-min)/2);
            }
        }
    }
}
