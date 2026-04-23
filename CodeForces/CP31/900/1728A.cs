namespace Leetcode.CodeForces.CP31._900
{
    internal class _1728A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                if(n==1)
                {
                    Console.WriteLine(0);
                    continue;
                }

                var a1 = a[0];
                var an = a[n - 1];

                var max = an;
                var min = a1;

                var maxdiff = an - a1;

                for (int j = 1; j < n - 1; j++)
                {
                    max = a[j] > max ? a[j] : max;
                    min = a[j] < min ? a[j] : min;
                    maxdiff = a[j - 1] - a[j] > maxdiff ? a[j - 1] - a[j] : maxdiff;
                }
                maxdiff = a[n - 2] - an > maxdiff ? a[n - 2] - an : maxdiff;
                maxdiff = an - min > maxdiff ? an - min : maxdiff;
                maxdiff = max - a1 > maxdiff ? max - a1 : maxdiff;

                Console.WriteLine(maxdiff);
            }
        }
    }
}
