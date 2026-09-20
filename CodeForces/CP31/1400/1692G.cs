namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1692G
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0],arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var lastswitch = 0;
                var ans = 0;

                for(int j=1;j<n;j++)
                {
                    if (a[j] * 2 <= a[j - 1]) lastswitch = j;

                    if (j - lastswitch >= k) ans++;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
