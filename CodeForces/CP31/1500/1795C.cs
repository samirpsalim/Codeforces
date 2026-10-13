namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1795C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var pr = new long[n + 1];

                for(int j =0; j < n; j++)
                {
                    pr[j+1] = pr[j] + b[j];
                }

                var cnt = new long[n];
                var ans = new long[n];

                for(int j = 0; j < n; j++)
                {
                    var idx = Array.BinarySearch(pr, pr[j] + a[j]);

                    if(idx < 0) idx = ~idx;

                    if(idx <=n)
                    {
                        ans[idx-1] += pr[j] + a[j] - pr[idx - 1];
                        cnt[idx-1]--;
                    }

                    cnt[j]++;
                }

                ans[0] += cnt[0] * b[0];

                for (int j = 1; j < n; j++)
                {
                    cnt[j] += cnt[j - 1];
                    ans[j] += cnt[j] * b[j];
                }

                Console.WriteLine(string.Join(' ', ans));
            }
        }
    }
}
