namespace Leetcode.CodeForces.CP31._1200
{
    internal enum Direction
    {
        Ascending,
        Descending,
        Either
    }

    internal class _1832C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var ans = 1;

                var dir = Direction.Either;

                for(int j = 1; j < n; j++)
                {
                    if(dir == Direction.Ascending && a[j] < a[j-1])
                    {
                        dir = Direction.Descending;
                        ans++;
                    }
                    else if (dir == Direction.Descending && a[j] > a[j - 1])
                    {
                        dir = Direction.Ascending;
                        ans++;
                    }
                    else if(dir == Direction.Either && a[j] != a[j-1])
                    {
                        ans++;
                        dir = a[j] > a[j-1] ? Direction.Ascending : Direction.Descending;
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
