namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1891B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, q) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var x = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var maxpow = 30;

                foreach(var xi in x)
                {
                    if(xi<=maxpow)
                    {
                        for(int j=0; j<n; j++)
                        {
                            a[j]= (a[j]%(1<<xi)==0)? a[j]+(1<<(xi-1)): a[j];
                        }
                        maxpow = xi - 1;
                        if(xi==0) break;
                    }
                }

                Console.WriteLine(string.Join(' ',a));
            }
        }
    }
}
