namespace Leetcode.CodeForces.CP31._900
{
    internal class _1543A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (a, b) = (arr[0], arr[1]);

                var maxgcd = a > b ? a - b : b - a;
                var ops = maxgcd ==0 
                          ? 0 
                          : maxgcd - (a % maxgcd) > (a % maxgcd)
                          ? (a % maxgcd)
                          : maxgcd - (a % maxgcd);

                Console.WriteLine($"{maxgcd} {ops}");
            }
        }
    }
}
