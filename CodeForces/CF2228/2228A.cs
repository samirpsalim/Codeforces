namespace Leetcode.CodeForces.CF2228
{
    internal class _2228A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var w = Console.ReadLine()!.Split(' ').Select(int.Parse).Where(ai=> ai!=0).ToArray();

                var ans = n-w.Length;


                var ones = w.Count(wi => wi == 1);
                var twos = w.Length -ones;

                var min = Math.Min(ones, twos);

                ones -= min;
                twos -= min;

                Console.WriteLine(ans+min+ (ones+twos)/3);

            }
        }
    }
}
