namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1610B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var start = 0;
                var end = n - 1;

                int possible1, possible2;

                while (start < end)
                {
                    if (a[start] != a[end])
                    {
                        break;
                    }
                    start++;
                    end--;
                }

                if(start >= end)
                {
                    Console.WriteLine("YES");
                    continue;
                }

                possible1 = a[start];
                possible2 = a[end];

                start=0;
                end = n - 1;
                while (a[start] ==possible1)
                {
                    start++;
                    if (start == n) break;
                }
                while (a[end] ==possible1)
                {
                    end--;
                    if(end <0) break;
                }

                var flag = false;

                while (start < end)
                {
                    if (a[start] != a[end])
                    {
                        flag = true;
                        break;
                    }
                    start++;
                    end--;
                    while (a[start] == possible1)
                    {
                        start++;
                        if (start == n) break;
                    }
                    while (a[end] == possible1)
                    {
                        end--;
                        if (end < 0) break;
                    }
                }

                if (!flag)
                {
                    Console.WriteLine("YES");
                    continue;
                }

                start = 0;
                end = n - 1;
                while (a[start] == possible2)
                {
                    start++;
                    if (start == n) break;
                }
                while (a[end] == possible2)
                {
                    end--;
                    if (end < 0) break;
                }

                flag = false;

                while (start < end)
                {
                    if (a[start] != a[end])
                    {
                        flag = true;
                        break;
                    }
                    start++;
                    end--;
                    while (a[start] == possible2)
                    {
                        start++;
                        if (start == n) break;
                    }
                    while (a[end] == possible2)
                    {
                        end--;
                        if (end < 0) break;
                    }
                }

                Console.WriteLine(flag? "NO" : "YES");
            }
        }
    }
}
