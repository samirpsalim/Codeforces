
namespace Leetcode.CodeForces.CP31._800
{
    internal class _1903A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i =0; i < t; i++)
            {
                var sizes = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (sizes[0],sizes[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(k != 1 || IsSorted(a) ? "YES" : "NO");
            }
        }

        private static bool IsSorted(int[] a)
        {
            for(int i=1; i<a.Length; i++)
            {
                if(a[i] < a[i-1])
                    return false;
            }
            return true;
        }
    }
}
