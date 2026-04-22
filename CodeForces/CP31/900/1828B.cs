namespace Leetcode.CodeForces.CP31._900
{
    internal class _1828B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var differenceSet = new HashSet<int>();

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    if (a[j]!=j+1) differenceSet.Add(Math.Abs(j + 1 - a[j]));
                }

                Console.WriteLine(Gcd(differenceSet));

                differenceSet.Clear();
            }
        }

        private static int Gcd(HashSet<int> differenceSet)
        {
            if(differenceSet.Count ==1) return differenceSet.First();

            return differenceSet.Aggregate((acc, ai) => Gcd(acc, ai));
        }

        private static int Gcd(int acc, int ai)
        {
            if (acc < ai) return Gcd(ai, acc);

            if (acc % ai == 0) return ai;
            
            return Gcd(ai, acc % ai);
        }
    }
}
