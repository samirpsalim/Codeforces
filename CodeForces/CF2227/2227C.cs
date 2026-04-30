namespace Leetcode.CodeForces.CF2227
{
    internal class _2227C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var modlists = new List<int>[6];

            for(int i=0; i<6; i++)
            {
                modlists[i] = new();
            }

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                foreach (var ai in a)
                {
                    modlists[ai%6].Add(ai);
                }

                var ans = modlists[0].Concat(modlists[2]).Concat(modlists[4])
                          .Concat(modlists[1]).Concat(modlists[5]).Concat(modlists[3]);

                Console.WriteLine(string.Join(' ',ans));

                foreach (var list in modlists)
                {
                    list.Clear();
                }
            }

        }
    }
}
