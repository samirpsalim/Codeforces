namespace Leetcode.CodeForces.CF2232
{
    internal class _2232B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var ans = new int[n];

                ans[0] = a[0];
                long sum = a[0];

                for (int j = 1; j < n; j++)
                {
                    sum+= a[j];
                    var avg = sum / (j + 1);
                    ans[j] = (int)Math.Min(ans[j-1], avg);
                }

                Console.WriteLine(string.Join(' ',ans));
            }
        }
    }
}
