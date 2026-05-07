namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1832B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                var currsum =a.Skip(2*k).Sum(ai=>(long)ai);

                var prefend = 2 * k - 1;
                var suffstart = n;

                var max = currsum;

                for(int j=0; j<k;++j)
                {
                    currsum += a[prefend] + a[prefend - 1] - a[suffstart-1];

                    prefend -= 2;
                    suffstart--;

                    max = max> currsum ? max : currsum;
                }

                Console.WriteLine(max);

            }
        }
    }
}
