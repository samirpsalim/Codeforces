namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1614B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).
                        Select((ai,idx)=>(ai,idx+1)).OrderByDescending(bi=>bi.ai).ToArray();

                var x = new int[n + 1];

                x[0] = (n + 3) / 2;
                var T = 0L;

                for(int j=0; j<n; j++)
                {
                    if(j%2==0)
                    {
                        var idx = a[j].Item2;
                        x[idx] = x[0]-1-j/2;
                        T += (long)2*a[j].ai * (1+j/2);
                    }
                    else
                    {
                        var idx = a[j].Item2;
                        x[idx] = x[0]+1+j / 2;
                        T += (long)2*a[j].ai *(1+j/2);
                    }
                }

                Console.WriteLine(T);
                Console.WriteLine(string.Join(' ',x));
            }
        }
    }
}
