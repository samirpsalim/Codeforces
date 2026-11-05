namespace Leetcode.CodeForces.CP31._1500
{
    internal class _960B
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n,k1,k2) = (arr[0],arr[1],arr[2]);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var diff = Enumerable.Range(0,n).Select(i => Math.Abs(a[i] - b[i])).OrderDescending().ToArray();
            var curptr = 0;
            var curadj=k1+k2;

            while (curptr < n)
            {
                if(curptr!=n-1)
                {
                    if ((curptr + 1) * (diff[curptr] - diff[curptr + 1]) <= curadj)
                    {
                        curadj -= (curptr + 1) * (diff[curptr] - diff[curptr + 1]);
                        curptr++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if ((curptr + 1) * diff[curptr] <= curadj)
                    {
                        curadj -= (curptr + 1) * diff[curptr];
                        curptr++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            var ans = 0L;

            if(curptr ==n)
            {
                Console.WriteLine(curadj%2);
                return;
            }

            for(int i=n-1; i>curptr; i--)
            {
                ans += (long)diff[i]*diff[i];
            }

            var d = (long)diff[curptr];
            var a1 = (long)curadj;
            var p = curptr + 1;
            var amodp = a1 % p;
            var aquotp = a1 / p;

            ans += (p - amodp) * (d - aquotp)* (d - aquotp) + amodp * (d - aquotp - 1) * (d - aquotp - 1);


            Console.WriteLine(ans);
        }
    }
}
