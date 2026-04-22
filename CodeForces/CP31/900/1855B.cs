namespace Leetcode.CodeForces.CP31._900
{
    internal class _1855B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = long.Parse(Console.ReadLine()!);

                long ans = 1;
                while(ans<n)
                {
                    if(n%(ans+1) ==0) ans++;
                    else break;
                }
                Console.WriteLine(ans);
            }
        }
    }
}
