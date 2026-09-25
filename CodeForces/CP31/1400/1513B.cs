namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1513B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var bitand = a.Aggregate((acc, ai) => acc & ai);

                var k = a.Count(ai=> ai==bitand);

                if(k<2)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    var modnum = 1_000_000_007;
                    var ans = ((long)k*(k-1))%modnum;

                    for(int j=1; j<=n-2; j++)
                    {
                        ans = (ans * j) % modnum;
                    }

                    Console.WriteLine(ans);
                }
            }
        }
    }
}
