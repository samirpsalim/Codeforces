namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1470A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, m) = (arr[0], arr[1]);

                var k = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                var c = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var start = m >= n ? 0 : n - m;
                var end = n - 1;
                var mid = (start + end)/2;

                while(start <end)
                {
                    if (k[mid] ==n-mid)
                    {
                        break;
                    }
                    if (k[mid] < n - mid)
                    {
                        start = mid+1;
                    }
                    else
                    {
                        end = mid;
                    }
                    mid = (start + end)/2;
                }

                var ans = 0L;
                for(int j=0; j<mid; j++)
                {
                    ans += c[k[j]-1];
                }

                for (int j = 0; j + mid < n; j++)
                {
                    ans += c[j];
                }

                Console.WriteLine(ans);
            }
        }
    }
}
