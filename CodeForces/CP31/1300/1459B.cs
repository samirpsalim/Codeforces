namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1459B
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var ans = (n % 2) switch
            {
                0 => (n+2)*(n+2)/4,
                1 => (n+3)*((n+2)/2),
                _=> 0
            };

            Console.WriteLine(ans);
        }
    }
}
