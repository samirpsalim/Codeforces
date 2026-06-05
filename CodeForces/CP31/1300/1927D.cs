namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1927D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                
                var poslist = new List<int>();
                poslist.Add(1);
                for (int j = 1; j < n; j++)
                {
                    if (a[j] != a[j-1]) poslist.Add(j+1);
                }

                var q = int.Parse(Console.ReadLine()!);

                for(int j = 0;j < q; j++)
                {
                    var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                    var (l,r) = (arr[0],arr[1]);

                    var start = 0;
                    var end = poslist.Count - 1;
                    var mid = (start + end+1) / 2;

                    while (start < end)
                    {
                        if (poslist[mid] == l)
                        {
                            break;
                        }
                        else if (poslist[mid] > l)
                        {
                            end = mid - 1;
                        }
                        else
                        {
                            start = mid;
                        }

                        mid = (start + end + 1) / 2;
                    }

                    if (mid == poslist.Count - 1)
                    {
                        Console.WriteLine("-1 -1");
                    }
                    else if (poslist[mid+1]>r)
                    {
                        Console.WriteLine("-1 -1");
                    }
                    else
                    {
                        Console.WriteLine($"{l} {poslist[mid+1]}");
                    }
                }

                Console.WriteLine("");
            }
        }
    }
}
