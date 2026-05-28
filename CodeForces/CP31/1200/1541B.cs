namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1541B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var ans = 0L;

                for (int j = 0; j < n - 1; j++)
                {
                    var curmod = (j + 1) % a[j];
                    var start = a[j]*((j+1)/a[j])+ a[j] - curmod;

                    if (start <= j + 1) start += a[j];

                    for (int k = start-1; k < n; k += a[j])
                    {
                        if (j + k + 2 == (long)a[j] * a[k])
                        {
                            ans++;
                        }
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
