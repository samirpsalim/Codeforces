namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1487B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                int ans;

                if(n%2==0)
                {
                    ans = k % n;
                    Console.WriteLine(ans == 0 ? n: ans);
                    continue;
                }
                ans = (k + (k - 1) / ((n - 1) / 2)) % n;
                Console.WriteLine(ans == 0 ? n : ans);
            }
        }
    }
}
