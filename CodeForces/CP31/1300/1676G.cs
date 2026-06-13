namespace Leetcode.CodeForces.CP31._1300
{
    internal class WhiteBlack
    {
        public int White { get; set; }
        public int Black { get; set; }
    }

    internal class _1676G
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                string s = Console.ReadLine()!;
                var dict = new Dictionary<int, WhiteBlack>();

                for (int j = n - 2; j >= 0; j--)
                {
                    if (!dict.ContainsKey(j + 2))
                    {
                        dict[j + 2] = new WhiteBlack();
                    }

                    if (s[j + 1] == 'W') dict[j + 2].White += 1;
                    else dict[j + 2].Black += 1;

                    var parentnode = a[j];
                    if (!dict.ContainsKey(parentnode))
                    {
                        dict[parentnode] = new WhiteBlack();
                    }

                    dict[parentnode].White += dict[j + 2].White;
                    dict[parentnode].Black += dict[j + 2].Black;
                }

                if(!dict.ContainsKey(1)) dict[1] = new WhiteBlack();

                if (s[0] == 'W') dict[1].White += 1;
                else dict[1].Black += 1;

                Console.WriteLine(dict.Values.Count(wb => wb.White == wb.Black));

            }
        }
    }
}
