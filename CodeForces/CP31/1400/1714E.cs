namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1714E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            HashSet<int> set2 = [1, 2, 4, 8, 13, 16, 17, 19];
            HashSet<int> set6 = [3, 6, 7, 9, 11, 12, 14, 18];

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var sets= new HashSet<int>();

                foreach (var ai in a)
                {
                    if (ai % 5 == 0) sets.Add(ai + ai % 10);
                    else if (set2.Contains(ai % 20)) sets.Add(2);
                    else sets.Add(6);

                    if(sets.Count>1) break;
                }

                Console.WriteLine(sets.Count > 1 ? "No" : "Yes");
            }

        }
    }
}
