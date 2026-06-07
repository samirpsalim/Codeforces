namespace Leetcode.CodeForces.CF2234
{
    internal class _2234A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).OrderDescending().ToArray();

                if(n==2)
                {
                    Console.WriteLine(string.Join(' ',a));
                    continue;
                }

                var flag = false;
                for(int j=2; j<n; j++)
                {
                    if (a[j - 2] % a[j - 1] != a[j])
                    {
                        flag = true;
                        break;
                    }
                }

                if(flag)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine($"{a[0]} {a[1]}");
                }

            }
        }
    }
}
