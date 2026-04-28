
namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1859B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var m = new int[n];
                var min =int.MaxValue;
                var sumsecondmins = 0L;
                var minsecondmin = int.MaxValue;

                for (int j = 0; j < n; j++)
                {
                    m[j] = int.Parse(Console.ReadLine()!);
                    UpdateMins(ref min, ref sumsecondmins,ref minsecondmin,
                        Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray());
                }

                Console.WriteLine(min+sumsecondmins-minsecondmin);
            }
        }

        private static void UpdateMins(ref int min, ref long sumsecondmins, ref int minsecondmin,int[] a)
        {
            var (firstmin,secondmin) = a[0] < a[1] 
                                       ? (a[0], a[1]) 
                                       : (a[1],a[0]);

            for (int i = 2; i < a.Length; i++)
            {
                if (a[i] < firstmin)
                {
                    secondmin = firstmin;
                    firstmin = a[i];
                }
                else if(secondmin > a[i])
                {
                    secondmin = a[i];
                }
            }

            (min, sumsecondmins, minsecondmin) = (firstmin<min?firstmin:min, sumsecondmins+secondmin,
                                                   minsecondmin<secondmin ? minsecondmin : secondmin);
        }
    }
}
