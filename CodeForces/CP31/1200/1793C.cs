namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1793C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var min = 1;
                var max = n;
                var l = 1;
                var r = n;

                while(r-l >2)
                {
                    if (a[r-1]!=max && a[r-1]!=min 
                        && a[l - 1] != max && a[l - 1] != min)
                    {
                        break;
                    }

                    if (a[l - 1] == min)
                    {
                        min++;
                        l++;
                    }
                    else if (a[l - 1] == max)
                    {
                        max--;
                        l++;
                    }

                    if (a[r - 1] == min)
                    {
                        min++;
                        r--;
                    }
                    else if (a[r - 1] == max)
                    {
                        max--;
                        r--;
                    }
                }

                Console.WriteLine(r - l > 2 ? $"{l} {r}" : "-1");
            }
        }
    }
}
