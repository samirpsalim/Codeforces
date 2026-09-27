namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1374D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (a[0],a[1]);

                a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var dict = new Dictionary<int, int>();

                foreach (var ai in a)
                {
                    if (ai % k == 0) continue;
                    else if (!dict.ContainsKey(ai % k)) dict[ai % k] = 1;
                    else dict[ai % k]++;
                }

                if(!dict.Any())
                {
                    Console.WriteLine(0);
                    continue;
                }

                var maxidx= dict.First().Key;

                foreach (var kv in dict)
                {
                    if (kv.Value > dict[maxidx]) maxidx = kv.Key;
                    else if(kv.Value == dict[maxidx]) maxidx = Math.Min(maxidx, kv.Key);
                }

                Console.WriteLine(1 + (long)dict[maxidx]*k-maxidx);
            }
        }
    }
}
