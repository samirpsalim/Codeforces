namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1338A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var maxdiff = 0;
                var maxval = a[0];

                for(int j=1; j < n; j++)
                {
                    if (maxdiff < maxval - a[j]) maxdiff = maxval - a[j];

                    if (a[j] > maxval)  maxval = a[j];
                }

                var ans = 0;

                while (maxdiff >= 1L << ans) ans++;

                Console.WriteLine(ans);
            }
        }
    }
}
