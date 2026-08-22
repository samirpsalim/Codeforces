namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1364B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var p = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var ans = new List<int>();
                ans.Add(p[0]);
                ans.Add(p[1]);

                foreach(var pi in p.Skip(2))
                {
                    if (ans[ans.Count - 1] > ans[ans.Count-2]
                        && pi > ans[ans.Count-1])
                    {
                        ans[ans.Count - 1] = pi;
                    }
                    else if (ans[ans.Count - 1] < ans[ans.Count - 2]
                        && pi < ans[ans.Count - 1])
                    {
                        ans[ans.Count - 1] = pi;
                    }
                    else
                    {
                        ans.Add(pi);
                    }
                }

                Console.WriteLine(ans.Count);
                Console.WriteLine(string.Join(' ', ans));
            }
        }
    }
}
