namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1698D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var start = 1;
                var end = n;
                var mid = (start + end) / 2;

                while (start < end)
                {
                    Console.WriteLine($"? {start} {mid}");

                    var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                    var inPlace = GetInPlaceNums(arr, start, mid);

                    if (inPlace % 2 == 0) start = mid + 1;
                    else end = mid;
                    mid = (start + end) / 2;
                }

                Console.WriteLine($"! {mid}");
            }
        }

        private static int GetInPlaceNums(int[] arr, int start, int end)
        {
            var beg = 0;
            var fin = arr.Length;
            var l = (beg + fin) / 2;
            while (beg < fin)
            {
                if (arr[l] >= start) fin = l;
                else beg = l + 1;
                l = (beg + fin) / 2;
            }

            if (l == arr.Length) return 0;

            beg = l-1;
            fin = arr.Length - 1;
            var r = (beg + fin + 1) / 2;
            while (beg < fin)
            {
                if (arr[r] <= end) beg = r;
                else fin = r - 1;
                r = (beg + fin + 1) / 2;
            }

            if(beg == fin && beg==-1) return 0;

            return r + 1 - l;
        }
    }
}
