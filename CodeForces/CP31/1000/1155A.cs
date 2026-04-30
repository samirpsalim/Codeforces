namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1155A
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);
            string s = Console.ReadLine()!;

            for(int i=0;i< n-1;i++)
            {
                if (s[i] > s[i+1])
                {
                    Console.WriteLine("YES");
                    Console.WriteLine($"{i + 1} {i + 2}");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
