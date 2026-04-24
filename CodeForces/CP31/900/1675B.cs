namespace Leetcode.CodeForces.CP31._900
{
    internal class _1675B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var flag = a[n-1] ==0;
                var ops = 0;

                if(!flag)
                {
                    for (int j = n - 2; j >= 0; j--)
                    {
                        while (a[j] >= a[j + 1])
                        {
                            a[j] /= 2;
                            ops++;
                        }
                        if (a[j] < j)
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                else if(n==1)
                {
                    flag = false;
                }

                Console.WriteLine(flag? -1 : ops);

            }
        }
    }
}
