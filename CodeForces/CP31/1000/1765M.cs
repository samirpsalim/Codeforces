namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1765M
    {
        private static List<int> _primes = new();
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var max = 2;
            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var found = false;

                for(int j=2; j<=Math.Ceiling(Math.Sqrt(n));++j)
                {
                    if (n % j == 0)
                    {
                        Console.WriteLine($"{n / j} {n - n / j}");
                        found = true;
                        break;
                    }
                }
                if(!found)
                {
                    Console.WriteLine($"1 {n-1}");
                }
            }
        }
    }
}
