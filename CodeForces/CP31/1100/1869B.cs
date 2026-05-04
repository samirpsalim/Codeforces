namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1869B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k,a,b) = (arr[0], arr[1], arr[2], arr[3]);

                var x = Enumerable.Range(0, n).Select(j=> Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray())
                        .Select(xi => (xi[0], xi[1])).ToArray();

                var acoord = x[a - 1];
                var bcoord = x[b - 1];

                if(a<=k && b<=k)
                {
                    Console.WriteLine(0);
                    continue;
                }

                var dirdist = Math.Abs(acoord.Item1 - bcoord.Item1) + (long)Math.Abs(acoord.Item2 - bcoord.Item2);

                if(k==0)
                {
                    Console.WriteLine(dirdist);
                    continue;
                }

                var amindist = x.Take(k)
                                .Min(xi => Math.Abs(acoord.Item1 - xi.Item1) + (long)Math.Abs(acoord.Item2 - xi.Item2));
                var bmindist = x.Take(k)
                                .Min(xi => Math.Abs(bcoord.Item1 - xi.Item1) + (long)Math.Abs(bcoord.Item2 - xi.Item2));

                Console.WriteLine(Math.Min(dirdist,amindist+bmindist));
            }
        }
    }
}
