
namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1567B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (a, b) = (arr[0], arr[1]);

                var totxor = (a % 4) switch
                {
                    0 => 0,
                    1 => a - 1,
                    2 => 1,
                    3 => a,
                    _ => -1
                };

                if (totxor == b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    var ans =(totxor ^ b) == a? a + 2: a + 1;

                    Console.WriteLine(ans);
                }
            }
        }
    }
}
