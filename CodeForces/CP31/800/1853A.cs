namespace Leetcode.CodeForces.CP31._800
{
    internal class _1853A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var mindiff = int.MaxValue;

                for (int j = 1; j < n; j++)
                {
                    if (a[j] < a[j-1])
                    {
                        mindiff=-1;
                        break;
                    }
                    else if (a[j] - a[j-1] <mindiff)
                    {
                        mindiff = a[j] - a[j - 1];
                    }
                }
                Console.WriteLine((mindiff+2)/2);
            }
        }
    }
}
