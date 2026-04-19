namespace Leetcode.CodeForces.CP31._800
{
    internal class _1761A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,a,b) = (arr[0], arr[1], arr[2]);

                Console.WriteLine(a+b>n-2 && a+b !=2*n ? "NO" : "YES");
            }
        }
    }
}
