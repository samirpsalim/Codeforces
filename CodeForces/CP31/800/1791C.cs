namespace Leetcode.CodeForces.CP31._800
{
    internal class _1791C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var s= Console.ReadLine();

                if (n == 1)
                {
                    Console.WriteLine(1);
                    continue;
                }

                var j = 0;
                while(2*j +n%2<n)
                {
                    if (s[j] == s[n-1-j]) break;
                    j++;
                }
                Console.WriteLine(n-2*j);

            }
        }
    }
}
