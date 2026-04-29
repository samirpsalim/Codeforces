namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1704B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (n, x) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var curmax = a[0];
                var curmin = a[0];
                var ans = 0;

                for (int j = 1; j < n; j++)
                {
                    curmax = a[j] < curmax ? curmax : a[j];
                    curmin = a[j] > curmin ? curmin : a[j];

                    if (curmax - curmin > 2 * x)
                    {
                        ans++;
                        curmax = curmin = a[j];
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
