namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1485A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (a,b) = (arr[0], arr[1]);

                var ans = int.MaxValue;
                var bdiff = 0;

                if(b==1)
                {
                    bdiff++;
                }

                while(bdiff<ans)
                {
                    ans = (int)Math.Min(bdiff+
                        Math.Floor(Math.Round(Math.Log(a,b+bdiff),12))+1,ans);
                    bdiff++;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
