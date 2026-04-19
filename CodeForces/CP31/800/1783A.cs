namespace Leetcode.CodeForces.CP31._800
{
    internal class _1783A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var maxpos = 0;
                var minpos = 0;

                for (int j = 0; j < n; j++)
                {
                    if (a[j] > a[maxpos]) maxpos = j;
                    if (a[j] < a[minpos]) minpos = j;
                }

                if(maxpos == minpos)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                (a[0], a[maxpos]) = (a[maxpos], a[0]);

                if (minpos == 0) minpos = maxpos;

                (a[1], a[minpos]) = (a[minpos], a[1]);

                Console.WriteLine("YES");
                Console.WriteLine(string.Join(' ', a));
            }
        }
    }
}
