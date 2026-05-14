namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1682B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .ToArray();

                var ans = int.MaxValue;

                for (int j = 0; j < n; j++)
                {
                   if(a[j] != j)
                   {
                        ans = ans & a[j];
                   }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
