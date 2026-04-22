namespace Leetcode.CodeForces.CP31._900
{
    internal class _1807D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
                var (n, q) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var prefsums = new long[n+1];
                prefsums[0] = 0;

                for(int j=1; j<=n; j++)
                {
                    prefsums[j]= prefsums[j-1]+a[j-1];
                }

                var sum = prefsums[n];

                for(int j=0; j<q; j++)
                {
                    arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
                    var (l,r,k) = (arr[0], arr[1], arr[2]);

                    Console.WriteLine((sum+k*(r+1-l)-prefsums[r]+prefsums[l-1])%2==1? 
                        "YES" :"NO");
                }
            }
        }
    }
}
