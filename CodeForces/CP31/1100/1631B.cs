namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1631B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .ToArray();

                var last = a[n - 1];
                var ans = 0;

                var j = n - 2;

                while (j >= 0)
                {
                    if (a[j] != last)
                    {
                        ans++;
                        j = 2 * j +1 - n;
                    }
                    else
                    {
                        j--;
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
