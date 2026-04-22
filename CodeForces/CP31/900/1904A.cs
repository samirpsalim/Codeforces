namespace Leetcode.CodeForces.CP31._900
{
    internal class _1904A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (a, b) = (arr[0], arr[1]);

                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (xk, yk) = (arr[0], arr[1]);

                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (xq, yq) = (arr[0], arr[1]);

                HashSet<(int, int)> ks = new()
                {
                    (xk+a, yk+b), (xk-a, yk+b), (xk+a, yk-b), (xk-a, yk-b),
                    (xk+b, yk+a), (xk-b, yk+a), (xk+b, yk-a), (xk-b, yk-a)
                };

                HashSet<(int, int)> qs = new()
                {
                    (xq+a, yq+b), (xq-a, yq+b), (xq+a, yq-b), (xq-a, yq-b),
                    (xq+b, yq+a), (xq-b, yq+a), (xq+b, yq-a), (xq-b, yq-a)
                };

                Console.WriteLine(ks.Count(p => qs.Contains(p)));
            }
        }
    }
}
