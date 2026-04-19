namespace Leetcode.CodeForces.CP31._800
{
    internal class _1777A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var count = 0;

                for(int j=1; j<n; j++)
                {
                    if (a[j] % 2 == a[j - 1] % 2) count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
