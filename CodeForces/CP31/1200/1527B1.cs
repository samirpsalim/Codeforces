namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1527B1
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var zerocount = Console.ReadLine()!.Count(si => si == '0');

                var ans = zerocount==1 ? "BOB" : (zerocount % 2) switch
                {
                    0 => "BOB",
                    1 => "ALICE"
                };
                Console.WriteLine(ans);
            }
        }
    }
}
