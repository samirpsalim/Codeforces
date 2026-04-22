namespace Leetcode.CodeForces.CP31._900
{
    internal class _1878C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (n, k,x) = (arr[0], arr[1], arr[2]);

                if(x>=k*(k+1)/2 && x<=(n*(n+1)-(n-k)*(n-k+1))/2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
