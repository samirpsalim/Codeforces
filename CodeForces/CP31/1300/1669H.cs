namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1669H
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var setbits = new int[31];

                for(int j = 0; j < n; j++)
                {
                    for(int l =0; l <= 30; l++)
                    {
                        if ((a[j] & (1 << l)) != 0) setbits[l]++;
                    }
                }

                var ans = 0;

                for(int j = 30;j >=0; j--)
                {
                    if (setbits[j]+k >=n)
                    {
                        ans += 1 << j;
                        k -= (n-setbits[j]);
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
