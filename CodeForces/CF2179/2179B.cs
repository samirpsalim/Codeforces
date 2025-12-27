namespace Leetcode.CodeForces.CF2179
{
    internal class _2179B
    {
        static void Solve(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);
            int sum, maxdiff, n, diff;

            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                sum = Math.Abs(a[1] - a[0]);
                maxdiff = sum;

                for (int j = 1; j < n-1; j++)
                {
                    sum += Math.Abs(a[j+1] -a[j]);
                    diff = Math.Abs(a[j + 1] - a[j]) + Math.Abs(a[j - 1] - a[j])
                        - Math.Abs(a[j + 1] - a[j - 1]);
                    maxdiff = maxdiff < diff ? diff : maxdiff;
                }

                diff = Math.Abs(a[n - 1] - a[n-2]);
                maxdiff = maxdiff < diff ? diff : maxdiff;
                Console.WriteLine(sum-maxdiff);

            }
        }
    }
}
