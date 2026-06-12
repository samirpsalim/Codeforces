namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1775B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var ExistingNums = new Dictionary<int,int>();
                var flag = false;
                var aarr = new List<int[]>();

                for (int j = 0; j < n; j++)
                {
                    var a = Console.ReadLine()!.Split(' ').Skip(1).Select(int.Parse).ToArray();
                    aarr.Add(a);

                    foreach (int ai in a)
                    {
                        if (ExistingNums.ContainsKey(ai)) ExistingNums[ai]++;
                        else ExistingNums[ai] = 1;
                    }
                }

                foreach(var a in aarr)
                {
                    if(a.All(ai => ExistingNums[ai] >1))
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
