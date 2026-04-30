namespace Leetcode.CodeForces.CP31._1000
{
    internal record Number(int val, HashSet<int> digits);
    internal class _1411B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var nstr = Console.ReadLine()!;
                var n = long.Parse(nstr);
                var ndigs = GetDigits(n);

                for(int j=0; j<2521; j++)
                {
                    if (ndigs.All(d => n % d == 0))
                        break;
                    n++;
                    ndigs = GetDigits(n);
                }
                Console.WriteLine(n);
            }
        }

        private static HashSet<int> GetDigits(long n)
        {
            var result = new HashSet<int>();

            while (n > 0)
            {
                var dig = n % 10;
                if(dig!=0)result.Add((int)dig);
                n /= 10;
            }
            return result;
        }
    }
}
