namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1798D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                if (a[0] == 0)
                {
                    Console.WriteLine("No");
                    continue;
                }

                var ans = new int[n];

                long sum = a[n - 1];
                ans[0] = a[n - 1];

                var l = 0;
                var r = n-2;

                for (int j = 1; j < n; j++)
                {
                    if (sum <= 0)
                    {
                        ans[j] = a[r];
                        r--;
                    }
                    else
                    {
                        ans[j] = a[l];
                        l++;
                    }

                    sum += ans[j];
                }

                Console.WriteLine("Yes");
                Console.WriteLine(string.Join(' ',ans));
            }
        }
    }
}
