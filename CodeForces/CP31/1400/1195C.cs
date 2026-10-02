namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1195C
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var h1 = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            var h2 = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var dp1= new long[n];
            var dp2= new long[n];

            var max1 = (long)h1[0];
            var max2 = (long)h2[0];

            Array.Copy(h1, dp1, n);
            Array.Copy(h2, dp2, n);

            for (int i = 1; i < n; i++)
            {
                dp1[i] = Math.Max(max2 + h1[i], dp1[i]);
                dp2[i] = Math.Max(max1 + h2[i], dp2[i]);

                max1 = Math.Max(max1, dp1[i]);
                max2 = Math.Max(max2, dp2[i]);
            }

            Console.WriteLine(Math.Max(max1,max2));
        }
    }
}
