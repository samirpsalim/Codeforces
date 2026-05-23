namespace Leetcode.CodeForces.CF2229
{
    internal class _2229B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var maxmin = 1;

                var maxsum = 0L;

                for(int j =0; j < n; j++)
                {
                    var max = Math.Max(a[j], b[j]);
                    var min = a[j]+ b[j] - max;

                    maxsum += max;
                    maxmin = Math.Max(min, maxmin);
                }

                Console.WriteLine(maxsum+maxmin);
            }
        }
    }
}
