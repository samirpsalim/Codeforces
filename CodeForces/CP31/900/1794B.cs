namespace Leetcode.CodeForces.CP31._900
{
    internal class _1794B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).
                    Select(x => x == 1 ? 2 : x).ToArray();

                for (int j = 1; j < n; j++)
                {
                    if (a[j] % a[j - 1] == 0) a[j]++;
                }
                Console.WriteLine(string.Join(' ',a));
            }
        }
    }
}
