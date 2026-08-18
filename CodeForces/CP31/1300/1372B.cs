namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1372B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var div = MinFactor(n);

                Console.WriteLine($"{n/div} {n-(n/div)}");
            }
        }

        private static int MinFactor(int n)
        {
            for (int i = 2;i*i<=n; i++)
            {
                if(n%i==0) return i;
            }
            return n;
        }
    }
}
