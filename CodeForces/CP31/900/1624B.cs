namespace Leetcode.CodeForces.CP31._900
{
    internal class _1624B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (a,b,c) = (arr[0], arr[1],arr[2]);

                var flag = false;

                if((2 * b - c) % a == 0 && (2 * b - c) / a >0)  flag = true;
                else if((2 * b - a) % c == 0 && (2 * b - a) / c > 0) flag = true;
                else if((a + c) % (2 * b) == 0 && (a + c) / (2 * b) > 0) flag = true;

                Console.WriteLine(flag ? "YES" : "NO");
            }
        }
    }
}
