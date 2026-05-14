namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1708B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, l,r) = (arr[0], arr[1], arr[2]);

                var flag = false;
                var ans = new int[n];

                for(int j=0; j<n; j++)
                {
                    var newnum = l % (j + 1) == 0 ? l : l + j + 1 - (l % (j + 1));
                    if(newnum>r)
                    {
                        flag = true;
                        break;
                    }
                    ans[j] = newnum;
                }

                if(flag)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(string.Join(' ',ans));
                }
            }
        }
    }
}
