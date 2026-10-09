namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1915F
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var ab = new (int, int)[n];

                for (int j = 0; j < n; j++)
                {
                    var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                    ab[j] =(arr[0], arr[1]);
                }

                Array.Sort(ab);

                var orderedList = new List<int>();

                var ans = 0L;

                for (int j = 0;j < n; j++)
                {
                    var index =InsertAndGetPosition(orderedList,ab[j].Item2);
                    ans += j - index;
                }

                Console.WriteLine(ans);
            }
        }

        static int InsertAndGetPosition(List<int> list, int val)
        {
            int index = list.BinarySearch(val);
            if (index < 0)
                index = index*(-1)-1;

            list.Insert(index, val);
            return index;
        }
    }
}
