namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1846E1
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var flag = false;

                for(int k=2; k*k < n; k++)
                {
                    var cur = (k - 1) * n + 1;
                    var k_cube = k * k * k;

                    if(cur%k_cube != 0) continue;

                    cur /= k_cube;
                    while(cur>1)
                    {
                        if (cur % k == 0) cur /= k;
                        else break;
                    }

                    if (cur ==1)
                    {
                        flag = true;
                        break;
                    }
                }

                Console.WriteLine(flag? "YES" : "NO");
            }
        }
    }
}
