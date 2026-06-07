namespace Leetcode.CodeForces.CF2234
{
    internal class _2234B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = long.Parse(Console.ReadLine()!);

                if(n%12 == 10)
                {
                    Console.WriteLine(n==10 ? "-1" : $"{22} {n-22}");
                }
                else
                {
                    Console.WriteLine($"{n%12} {n-(n%12)}");
                }
            }
        }
    }
}
