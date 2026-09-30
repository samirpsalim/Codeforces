namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1320A
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var bdict = new Dictionary<int, long>();

            for (int i = 0; i < n; i++)
            {
                var key = a[i] - i;
                if (bdict.ContainsKey(key)) bdict[key] += a[i];
                else bdict[key] = a[i];
            }

            Console.WriteLine(bdict.Values.Max());
        }
    }
}
