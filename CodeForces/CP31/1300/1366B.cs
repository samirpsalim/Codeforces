namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1366B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,x,m) = (arr[0], arr[1], arr[2]);

                var left = x; 
                var right = x;

                for(int j=0; j<m; j++)
                {
                    arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                    var (l, r) = (arr[0], arr[1]);

                    if(l<left && r>=left)
                    {
                        left = l;
                    }
                    if(r>right && l<=right)
                    {
                        right = r;
                    }

                }
                Console.WriteLine(right+1-left);
            }
        }
    }
}
