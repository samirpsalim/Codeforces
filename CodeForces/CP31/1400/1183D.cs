namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1183D
    {
        static void Solve(string[] args)
        {
            var q = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < q; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var countdict = new Dictionary<int, int>();

                var atleastdict = new Dictionary<int, int>();

                var maxcount = 0;
                
                foreach(var ai in a)
                {
                    if(countdict.ContainsKey(ai))
                    {
                        countdict[ai]++;
                        var count = countdict[ai];
                        if (atleastdict.ContainsKey(count))
                        {
                            atleastdict[count]++;
                        }
                        else
                        {
                            atleastdict[count] = 1;
                            maxcount=count;
                        }
                    }
                    else
                    {
                        countdict[ai]=1;
                        var count = countdict[ai];
                        if (atleastdict.ContainsKey(count))
                        {
                            atleastdict[count]++;
                        }
                        else
                        {
                            atleastdict[count] = 1;
                            maxcount = count;
                        }
                    }
                }

                var ans = 0L;

                var curcount = 0;

                for(int j=maxcount; j>0; j--)
                {
                    if (atleastdict[j] > curcount)
                    {
                        ans += j;
                        curcount++;
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
