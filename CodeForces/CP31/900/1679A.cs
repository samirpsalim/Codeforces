namespace Leetcode.CodeForces.CP31._900
{
    internal class _1679A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = long.Parse(Console.ReadLine()!);

                if(n%2!=0 || n==2)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                var min = (n + 4) / 6;

                var max = n / 4;

                Console.WriteLine($"{min} {max}");
            }
        }
    }
}
