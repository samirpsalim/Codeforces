namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1725B
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (N, D) = (arr[0], arr[1]);

            var P = Console.ReadLine()!.Split(' ').Select(int.Parse).
                    Order().Reverse().ToArray();

            var teamcount = 0;
            var playercount = 0;

            foreach (var Pi in P)
            {
                if ((long)Pi * (N - playercount) > D)
                {
                    teamcount++;
                    playercount += (D + 1) / Pi + ((D + 1) % Pi == 0 ? 0 : 1);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(teamcount);
        }
    }
}