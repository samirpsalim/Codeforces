namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1729D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var x = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var y = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var a = new int[n];
                var negnums = 0;

                for(int j = 0; j < n; j++)
                {
                    var aj = y[j] - x[j];
                    if(aj<0) negnums++;
                    a[j] = aj;
                }

                Array.Sort(a);

                var negpoint = negnums - 1;
                var pospoint = negnums;

                var nums = (n - negnums);

                while (pospoint < n - 1)
                {
                    if (a[pospoint] == 0)
                    {
                        pospoint += 2;
                    }
                    else
                    {
                        break;
                    }
                }

                while (negpoint >= 0 && pospoint < n)
                {
                    if (a[pospoint] + a[negpoint] >=0)
                    {
                        nums++;
                        negpoint--;
                        pospoint++;
                    }
                    else
                    {
                        pospoint++;
                    }
                }

                Console.WriteLine(nums/2);
            }
        }
    }
}
