namespace Leetcode.CodeForces.CP31._900
{
    internal class _1475A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = long.Parse(Console.ReadLine()!);

                var pow2 = 2L;
                var flag = false;
                while (n > pow2)
                {
                    if (n % pow2 != 0)
                    {
                        flag = true;
                        break;
                    }
                    pow2 *= 2;
                }

                Console.WriteLine(flag? "YES" : "NO");
            }
        }
    }
}
