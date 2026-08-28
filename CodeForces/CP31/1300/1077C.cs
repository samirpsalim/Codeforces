namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1077C
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var countdict = new Dictionary<long, int>();
            var sum = 0L;

            for (int i = 0; i < n; i++)
            {
                if(countdict.ContainsKey(a[i]))
                {
                    countdict[a[i]]++;
                }
                else
                {
                    countdict[a[i]] = 1;
                }
                sum += a[i];
            }   
            
            var ans = new List<int>();
        
            for (int i = 0;i < n; i++)
            {
                if ((sum - a[i])%2!=0)
                {
                    continue;
                }
                long half = (sum - a[i]) / 2;

                if(half == a[i])
                {
                    if (countdict[half]>1)
                        ans.Add(i+1);
                }
                else if (countdict.ContainsKey(half))
                {
                    ans.Add(i+1);
                }
            }

            Console.WriteLine(ans.Count);
            Console.WriteLine(string.Join(' ',ans));
        }
    }
}
