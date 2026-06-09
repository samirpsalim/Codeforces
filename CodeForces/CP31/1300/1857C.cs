namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1857C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var maxdiff = Enumerable.Range(0, n).Max(j => a[j] - b[j]);

                var ans = new List<int>();

                for(int j=0; j<n;++j)
                {
                    if (a[j]-b[j] == maxdiff) ans.Add(j+1);
                }

                Console.WriteLine(ans.Count);
                Console.WriteLine(string.Join(" ", ans));
            }
        }
    }
}
