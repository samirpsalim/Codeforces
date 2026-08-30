namespace Leetcode.CodeForces.CP31._1300
{
    internal class _808B
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n, k) = (arr[0], arr[1]);

            var a = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

            var weekcount = n - k + 1;

            var quot = 0L;
            var rem = 0L;

            for(int i=0; i<n; ++i)
            {
                int[] potfactors = [i + 1, k, weekcount, n - i];
                long factor =potfactors.Min();

                var prod = factor * a[i];

                quot += prod / weekcount;
                rem += prod % weekcount;

                if(rem/weekcount >0)
                {
                    quot += rem / weekcount;
                    rem %= weekcount;
                }
            }

            decimal ans = quot;
            ans += ((decimal)rem) / weekcount;

            Console.WriteLine($"{ans:F7}");

        }
    }
}
