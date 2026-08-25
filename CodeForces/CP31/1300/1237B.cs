namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1237B
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var bindex = 0;
            var aindex = 0;
            
            var overtakeset = new HashSet<int>();

            while(bindex<n && aindex<n)
            {
                if (b[bindex] == a[aindex])
                {
                    bindex++;
                    aindex++;

                    while(aindex<n && overtakeset.Contains(a[aindex]))
                    {
                        aindex++;
                    }
                }
                else
                {
                    if(overtakeset.Contains(b[bindex]))
                    {
                        bindex++;
                    }
                    else
                    {
                        overtakeset.Add(b[bindex]);
                        bindex++;
                    }
                }
            }

            Console.WriteLine(overtakeset.Count);
        }
    }
}
