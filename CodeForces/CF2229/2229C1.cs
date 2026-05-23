namespace Leetcode.CodeForces.CF2229
{
    internal class _2229C1
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var ans = new List<int>();

                var sign = -1;

                for (int j = n-1; j >=0; j--)
                {
                    var cursign = Math.Sign(a[j]);
                    if (cursign != sign)
                    {
                        ans.Add(j+1);
                        sign = cursign;
                    }
                }

                Console.WriteLine(ans.Count);
                Console.WriteLine(string.Join(" ",ans));
            }
        }
    }
}
