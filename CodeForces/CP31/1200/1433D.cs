namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1433D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var firstidx = 0;
                var secindx = -1;

                for(int j =1; j<n; ++j)
                {
                    if (a[j]!= a[firstidx])
                    {
                        secindx = j;
                        break;
                    }
                }

                if(secindx == -1)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                    for(int j = 1; j<n; ++j)
                    {
                        if(a[j]!= a[firstidx])
                        {
                            Console.WriteLine($"{firstidx+1} {j+1}");
                        }
                        else
                        {
                            Console.WriteLine($"{secindx + 1} {j + 1}");
                        }
                    }
                }
            }
        }
    }
}
