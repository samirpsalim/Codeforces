namespace Leetcode.CodeForces.CP31._800
{
    internal class _1901A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var sizes = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, x) = (sizes[0], sizes[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var max = a[0];

                for(int j=1; j<n;++j)
                {
                    if (a[j] - a[j - 1] > max) max = a[j] - a[j - 1];
                }
                if (2 * (x - a[n - 1]) > max) max = 2 * (x - a[n - 1]);

                Console.WriteLine(max);
            }
        }
    }
}
