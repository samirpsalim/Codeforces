namespace Leetcode.CodeForces.CP31._800
{
    internal class _1834A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var sum = Console.ReadLine()!.Split(' ').Select(int.Parse).Sum();
                var negs = (n - sum) / 2;

                if (negs % 2 == 0)
                {
                    if (sum >= 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(2 * ((3 - sum) / 4));
                    }
                }
                else
                {
                    if (sum >= -1)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(1 + 2 * ((1 - sum) / 4));
                    }
                }
            }
        }
    }
}
