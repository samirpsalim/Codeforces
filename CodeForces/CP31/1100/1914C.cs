namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1914C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
                var b = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var ans = a[0] + (k - 1) * b[0];

                var maxb = b[0];
                var asum = a[0];

                for(int j=1; j<Math.Min(n,k);j++)
                {
                    asum += a[j];
                    maxb = Math.Max(maxb, b[j]);
                    ans = Math.Max(ans,asum+(k-(j+1))*maxb);
                }
                Console.WriteLine(ans);
            }
        }
    }
}
