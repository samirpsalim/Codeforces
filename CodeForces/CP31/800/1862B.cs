namespace Leetcode.CodeForces.CP31._800
{
    internal class _1862B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var a = new List<int>();

                a.Add(b[0]);

                for (int j = 1; j<n; j++)
                {
                    if (b[j] < b[j-1])
                        a.Add(b[j]);
                    a.Add(b[j]);
                }

                Console.WriteLine(a.Count);
                Console.WriteLine(string.Join(' ',a));
            }
        }
    }
}
