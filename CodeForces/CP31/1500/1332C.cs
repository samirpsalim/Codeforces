namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1332C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0],arr[1]);

                string s = Console.ReadLine()!;

                var alphdict = new Dictionary<char, int>[k];

                for (int j = 0; j < n; j++)
                {
                    var kmod = j % k;
                    var rmod = (n - 1 - j) % k;
                    kmod = kmod > rmod ? rmod : kmod;

                    if (alphdict[kmod] is null) alphdict[kmod] = new();
                    var curdict = alphdict[kmod];
                   
                    if (!curdict.ContainsKey(s[j])) curdict[s[j]] = 1;
                    else curdict[s[j]]++;
                }

                var ans = alphdict.Where(dict => dict is not null).Select(dict => dict.Values.Sum() - dict.Values.Max()).Sum();
                Console.WriteLine(ans);
            }
        }
    }
}
