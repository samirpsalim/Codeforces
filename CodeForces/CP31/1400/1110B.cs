namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1110B
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n,m,k) = (arr[0],arr[1],arr[2]);

            var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var ans = b[n - 1] - b[0]+1;

            var lengths = new int[n - 1];

            for (int i = 0; i < n-1; i++)
            {
                lengths[i] = b[i + 1] - b[i]-1;
            }

            ans -=lengths.OrderDescending().Take(k - 1).Sum();

            Console.WriteLine(ans);
        }
    }
}
