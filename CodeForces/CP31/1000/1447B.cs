namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1447B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, m) = (arr[0], arr[1]);

                var (sum, minabs, negcount) = Enumerable.Range(0, n).
                    Select(i => Console.ReadLine()!.Split(' ').Select(int.Parse)).
                    Aggregate((0, 100, 0), (acc, ai) =>
                    (acc.Item1 + ai.Sum(aij=> Math.Abs(aij)),
                    Math.Min(acc.Item2, ai.Min(aij => Math.Abs(aij))),
                    acc.Item3 + ai.Count(aij => aij <= 0)));

                if(negcount%2==0)
                {
                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine(sum - 2 * minabs);
                }
            }
        }
    }
}
