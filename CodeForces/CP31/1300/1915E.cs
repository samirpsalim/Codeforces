namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1915E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var sumSet = new HashSet<long>();

            for (int i = 0; i < t; i++)
            {
                sumSet.Add(0);
                var lastSum = 0L;
                var flag = false;

                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    lastSum = j % 2 == 0 ? lastSum + a[j] : lastSum - a[j];

                    if (!sumSet.Add(lastSum))
                    {
                        flag = true;
                        break;
                    }
                }

                Console.WriteLine(flag ? "YES" : "NO");

                sumSet.Clear();
            }
        }
    }
}
