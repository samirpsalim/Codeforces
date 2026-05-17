namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1857C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var b = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .Order().ToArray();

                var a = new int[n];

                var pos = 0;

                for (int j = 0; j < n-1; j++)
                {
                    a[j] = b[pos];

                    pos += (n - 1 - j);
                }
                a[n - 1] = a[n - 2];

                Console.WriteLine(string.Join(' ',a));
            }
        }
    }
}
