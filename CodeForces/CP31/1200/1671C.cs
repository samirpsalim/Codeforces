namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1671C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,x) = (arr[0],arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                var sum = 0L;
                var ans = 0L;

                for(int j=0; j<n; j++)
                {
                    sum += a[j];

                    if(sum>x)
                    {
                        break;
                    }

                    var diff = x-sum;
                    var diffcount = diff / (j + 1);
                    ans+= diffcount+1;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
