namespace Leetcode.CodeForces.CP31._900
{
    internal class _1380A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var p = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var endofDesc = 0;
                var startofAsc = n - 1;

                while(endofDesc <n-1)
                {
                    if (p[endofDesc] > p[endofDesc+1]) endofDesc++;
                    else break;
                }

                while(startofAsc > endofDesc)
                {
                    if (p[startofAsc] > p[startofAsc- 1]) startofAsc--;
                    else break;
                }

                if(startofAsc <endofDesc+2)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");

                    var maxidx = endofDesc + 1;
                    for(int j= endofDesc + 1; j<startofAsc; j++)
                    {
                        if (p[maxidx] < p[j]) maxidx = j;
                    }

                    Console.WriteLine($"{endofDesc+1} {maxidx+1} {startofAsc+1}");
                }
            }
        }
    }
}
