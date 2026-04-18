namespace Leetcode.CodeForces.CP31._800
{
    internal class _1814A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var a = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (n, k) = (a[0], a[1]);

                Console.WriteLine(n%2==0 || (k%2==1) && (n>=k) ? "YES" : "NO");
            }
        }
    }
}
