namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1821B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var adash = Console.ReadLine()!.Split(' ').Select(int.Parse)
                            .ToArray();

                var start = 1;
                var end = n;

                for(int j=0; j<n; j++)
                {
                    if (a[j] != adash[j])
                    {
                        break;
                    }
                    start++;
                }

                for (int j = n - 1; j >= 0; j--)
                {
                    if (a[j] != adash[j])
                    {
                        break;
                    }
                    end--;
                }
                    
                if (start==n)
                {
                    Console.WriteLine($"1 {n}");
                    continue;
                }

                var min = a[start - 1];
                var max = a[end - 1];
                for(int j=start-1; j<end; j++)
                {
                    min = Math.Min(min, a[j]);
                    max = Math.Max(max, a[j]);
                }

                for(int j=start-2; j>=0; j--)
                {
                    if(a[j] > min)
                    {
                        break;
                    }
                    min = a[j];
                    start--;
                }

                for (int j = end; j <n; j++)
                {
                    if (a[j] <max)
                    {
                        break;
                    }
                    max = a[j];
                    end++;
                }

                Console.WriteLine($"{start} {end}");
            }
        }
    }
}
