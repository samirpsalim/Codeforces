namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1119B
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n, h) = (arr[0], arr[1]);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var ans = 0;
            var maxh = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) maxh += a[i];

                int j = i;
                while (j > 0)
                {
                    if (a[j] < a[j - 1]) break;

                    maxh += j % 2 == 0 ? (a[j - 1] - a[j]) : (a[j] - a[j - 1]);
                    (a[j - 1], a[j]) = (a[j], a[j - 1]);
                    j--;
                }

                if (maxh > h) break;
                else ans++;
            }

            Console.WriteLine(ans);
        }
    }
}
