namespace Leetcode.CodeForces.CP31._900
{
    internal class _1374B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var count3 = 0;
                var count2 = 0;

                while(n%3 == 0)
                {
                    count3++;
                    n/=3;
                }

                while (n % 2 == 0)
                {
                    count2++;
                    n /= 2;
                }

                if (n != 1 || count3 < count2) Console.WriteLine(-1);
                else Console.WriteLine(2*count3 - count2);

            }
        }
    }
}
