namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1646C
    {
        static void Solve(string[] args)
        {
            var factorials = new long[12];

            var fact = 2L;
            for (int i = 3; i <=14; i++)
            {
                fact *= i;
                factorials[i-3] = fact;
            }

            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = long.Parse(Console.ReadLine()!);

                var pos = Array.BinarySearch(factorials, n);

                if(pos<0)
                {
                    Console.WriteLine(GetNumCount(n, factorials,~pos-1));
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
        }

        private static int GetNumCount(long n, long[] factorials, int pos)
        {
            if (pos < 0) return GetSetBits(n);
            if (n == factorials[pos]) return 1;

            var remnum = n-factorials[pos];
            var nextpos = Array.BinarySearch(factorials, remnum);
            if (nextpos < 0) nextpos = ~nextpos - 1;

            return Math.Min(1+GetNumCount(remnum, factorials, Math.Min(nextpos,pos-1)), GetNumCount(n, factorials, pos - 1));
        }

        private static int GetSetBits(long n)
        {
            var ans = 0;
            while (n > 0)
            {
                if(n%2==1) ans++;

                n = n >> 1;
            }
            return ans;
        }
    }
}
