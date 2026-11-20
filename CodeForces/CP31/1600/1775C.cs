namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1775C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (n,x) = (arr[0],arr[1]);

                var possible = true;
                var lub = 2*n;
                var glb = n;

                var j = 0;
                while((n>>j) >0 || (x >> j) > 0)
                {
                    if((n >> j) % 2==0 && (x >> j) % 2==1)
                    {
                        possible = false;
                        break;
                    }
                    if ((n >> j) % 2 == 1 && (x >> j) % 2 == 1)
                    {
                        var div = 1L << j;
                        lub = Math.Min(lub, (n/div+1)*div-1);
                    }
                    else if((n >> j) % 2 == 1 && (x >> j) % 2 == 0)
                    {
                        var div = 1L << j;
                        glb = Math.Max(glb, (n / div + 1) * div);
                    }
                    j++;
                }

                if(!possible) Console.WriteLine(-1);
                else if(glb>lub) Console.WriteLine(-1);
                else Console.WriteLine(glb);
            }
        }
    }
}
