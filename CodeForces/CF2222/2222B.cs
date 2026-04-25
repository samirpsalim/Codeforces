namespace Leetcode.CodeForces.CF2222
{
    internal class _2222B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,m) = (arr[0],arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var oddidxcount = Console.ReadLine()!.Split(' ').Select(int.Parse).Count(xi => xi%2==1);
                var evenidxcount = m-oddidxcount;

                var oddidxarr = new int[(n+1)/2];
                var evenidxarr = new int[n/2];

                for(int j =0; j < n; j++)
                {
                    if(j%2 == 0)
                    {
                        oddidxarr[j/2] = a[j];
                    }
                    else
                    {
                        evenidxarr[j/2] = a[j];
                    }
                }

                Array.Sort(oddidxarr);
                Array.Sort(evenidxarr);

                var sum = 0L;

                var last = (n + 1) / 2 - (oddidxcount > 0 ? 1 : 0);
                for (int j = 0; j < last; j++)
                {
                    if (oddidxcount + j < (n + 1) / 2)
                    {
                        sum += oddidxarr[j];
                    }
                    else if (oddidxarr[j] < 0)
                    {
                        sum += oddidxarr[j];
                    }
                    else
                    {
                        break;
                    }
                }

                last = n / 2 - (evenidxcount > 0 ? 1 : 0);
                for (int j = 0; j < last; j++)
                {
                    if (evenidxcount + j < n / 2)
                    {
                        sum += evenidxarr[j];
                    }
                    else if (evenidxarr[j] < 0)
                    {
                        sum += evenidxarr[j];
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine(sum);

            }
        }
    }
}
