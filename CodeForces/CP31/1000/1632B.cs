namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1632B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var maxbitvalue = 1;

                while(n-1 >= 2*maxbitvalue)
                {
                    maxbitvalue *= 2;
                }
                Console.WriteLine(string.Join(' ',
                    Enumerable.Range(maxbitvalue,n-maxbitvalue).Reverse()
                    .Concat(Enumerable.Range(0,maxbitvalue))));
            }
        }
    }
}
