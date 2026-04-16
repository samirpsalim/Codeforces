namespace Leetcode.CodeForces.CP31._800
{
    internal class _1859A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Array.Sort(a);

                if (a.Distinct().Count() == 1)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                List<int> b = new List<int>(n);
                List<int> c = new List<int>(n);
                c.Add(a[n-1]);

                var comparefirst = true;

                for(int j=n-2; j>=0; j--)
                {
                    if (comparefirst)
                    {
                        if (a[j]== a[j+1])
                        {
                            c.Add(a[j]);
                            continue;
                        }
                        b.Add(a[j]);
                        comparefirst=false;
                        continue;
                    }
                    b.Add(a[j]);
                }

                Console.WriteLine($"{b.Count} {c.Count}");
                Console.WriteLine(string.Join(' ', b));
                Console.WriteLine(string.Join(' ', c));
            }
        }
    }
}
