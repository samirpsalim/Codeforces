namespace Leetcode.CodeForces.CP31._900
{
    internal class _1440B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var step = n + 1 - (n + 1) / 2;
                var start = k * ((n + 1) / 2 - 1);

                var sum = 0L;

                for(int j=0; j<k;++j)
                {
                    sum += a[start + j * step];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
