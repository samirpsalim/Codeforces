namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1167B
    {
        static void Solve(string[] args)
        {
            var ans = new int[6];

            for(int i=0; i<2; i++)
            {
                int p12;
                int p13;
                Console.WriteLine($"? {3 * i+1} {3*i+2}");
                p12=int.Parse(Console.ReadLine()!);
                Console.WriteLine($"? {3 * i + 1} {3 * i + 3}");
                p13 = int.Parse(Console.ReadLine()!);

                var seg = GetSegment(p12, p13);

                for(int j=0; j<3; j++)
                {
                    ans[3 * i + j] = seg[j];
                }
            }

            Console.WriteLine($"! {string.Join(' ',ans)}");
        }

        private static int[] GetSegment(int p12, int p13)
        {
            var fact12 = Factorize(p12);
            var fact13 = Factorize(p13);

            int firstnum;

            if (fact13.Contains(fact12[0])) firstnum = fact12[0];
            else firstnum = fact12[1];

            return [firstnum, p12 / firstnum, p13 / firstnum];
        }

        private static int[] Factorize(int prod)
        {
            if (prod % 42 == 0) return [42, prod / 42];
            if (prod % 23 == 0) return [23, prod / 23];
            if (prod % 15 == 0) return [15, prod / 15];
            if (prod == 128) return [16, 8];
            if (prod == 64) return [16, 4];
            
            return [8, 4];
        }
    }
}
