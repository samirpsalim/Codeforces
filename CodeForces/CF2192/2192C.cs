using System.Buffers;

namespace Leetcode.CodeForces.CF2192
{
    internal class _2192C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            ArrayPool<long> arrayPool = ArrayPool<long>.Shared;

            for (int i = 0; i < t; i++)
            {
                var metalist = Console.ReadLine()!.Split(' ').
                    Select(x => long.Parse(x)).ToArray();
                var a = Console.ReadLine()!.Split(' ').
                    Select(x => long.Parse(x)).ToArray();
                var pfxsum = arrayPool.Rent((int)metalist[0]);
                var sucmax = arrayPool.Rent((int)metalist[0]);
                var pfxmin = arrayPool.Rent((int)metalist[0]);

                pfxsum[0] = a[0];
                pfxmin[0] = a[0];
                sucmax[metalist[0] - 1] = 0;

                for (int j = 1; j < metalist[0]; j++)
                {
                    pfxsum[j] = pfxsum[j - 1] + a[j];
                    pfxmin[j] = pfxmin[j - 1] <= a[j] ? pfxmin[j - 1] : a[j];
                }

                if (metalist[1] % pfxsum[metalist[0] - 1] == 0)
                {
                    var rounds = metalist[1] / pfxsum[metalist[0] - 1];
                    Console.WriteLine(metalist[0] * rounds + metalist[2] * (rounds - 1));
                }
                else
                {
                    var rounds = metalist[1] / pfxsum[metalist[0] - 1];
                    var time = metalist[0] * rounds + metalist[2] * rounds;
                    var hleft = metalist[1] % pfxsum[metalist[0] - 1];
                    sucmax[metalist[0] - 2] = a[metalist[0] - 1];
                    for (int j = (int)metalist[0] - 3; j >= 0; j--)
                    {
                        sucmax[j] = sucmax[j + 1] >= a[j + 1] ? sucmax[j + 1] : a[j + 1];
                    }
                    for (int j = 0; j < metalist[0]; j++)
                    {
                        var diff = sucmax[j] - pfxmin[j] > 0
                            ? sucmax[j] - pfxmin[j] : 0;
                        if (hleft <= pfxsum[j] + diff)
                        {
                            Console.WriteLine(time + j + 1);
                            break;
                        }
                    }
                }

                arrayPool.Return(pfxmin);
                arrayPool.Return(sucmax);
                arrayPool.Return(pfxsum);
            }
        }
    }
}
