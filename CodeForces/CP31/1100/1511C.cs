namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1511C
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n,q) = (arr[0], arr[1]);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var t = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var coldict = new Dictionary<int, int>(50);

            for(int j=0; j<n; j++)
            {
                if(!coldict.ContainsKey(a[j]))
                {
                    coldict[a[j]] = j+1;

                    if(coldict.Count==50) break;
                }
            }

            foreach(var tj in t)
            {
                var caseans = coldict[tj];
                foreach(var kj in coldict.Keys)
                {
                    if(coldict[kj] < caseans)
                    {
                        coldict[kj]++;
                    }
                }
                Console.Write($"{caseans} ");
                coldict[tj] = 1;
            }
        }
    }
}
