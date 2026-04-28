namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1840C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k,q) = (arr[0], arr[1],arr[2]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var curarrlen = 0;
                var possibilities = 0L;

                for(int j=0;j<n;++j)
                {
                    if (a[j]>q)
                    {
                        if(curarrlen>=k)
                        {
                            possibilities += (long)(curarrlen + 1 - k) * (curarrlen + 2 - k) / 2;
                        }
                        curarrlen = 0;
                    }
                    else
                    {
                        curarrlen++;
                    }
                }

                if (curarrlen >= k)
                {
                    possibilities += (long)(curarrlen + 1 - k) * (curarrlen + 2 - k) / 2;
                }

                Console.WriteLine(possibilities);
            }
        }
    }
}
