namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1656B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .ToArray();

                var (n,k) = (arr[0],arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToHashSet();

                var flag = false;

                foreach(var ai in a)
                {
                    if (a.Contains(ai - k) || a.Contains(ai + k))
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
