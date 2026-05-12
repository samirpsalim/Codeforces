namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1807G2
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .Order().ToArray();

                if (a[0]!=1)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                var sum = 1L;
                var flag = true;

                for (int j = 1; j < n; j++)
                {
                    if(a[j] > sum)
                    {
                        flag = false;
                        break;
                    }
                    sum += a[j];
                }

                Console.WriteLine(flag ? "YES" : "NO");
            }
        }
    }
}
