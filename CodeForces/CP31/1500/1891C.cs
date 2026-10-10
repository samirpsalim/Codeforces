namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1891C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                var l = 0;
                var r = n - 1;

                var x = 0;
                var ans = 0L;

                while (l <= r)
                {
                    if (l == r)
                    {
                        ans += (a[l] - x) / 2 + (a[l] - x) % 2 + Math.Min(a[l]/2,1);
                        break;
                    }

                    if (x + a[l] < a[r])
                    {
                        ans += a[l];
                        x += a[l];
                        l++;
                    }
                    else if (x + a[l] >= a[r])
                    {
                        ans += a[r]-x + 1;
                        a[l] -= a[r] - x;
                        x = 0;
                        r--;
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
