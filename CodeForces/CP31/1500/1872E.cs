namespace Leetcode.CodeForces.CP31._1500
{
    internal class SpecialStructure
    {
        public int xor0sum {  get; private set; }
        public int xor1sum { get; private set; }

        private int[] xorTotArray;

        public SpecialStructure(int[] a, string s)
        {
            xorTotArray = new int[a.Length+1];

            for (int i = 0; i < a.Length; i++)
            {
                xorTotArray[i + 1] = xorTotArray[i] ^ a[i];

                if (s[i] =='1') xor1sum ^= a[i];
                else xor0sum ^= a[i];
            }
        }

        public void FlipBitString(int start, int end)
        {
            var xorseg = xorTotArray[start-1] ^ xorTotArray[end];

            xor0sum ^= xorseg;
            xor1sum ^= xorseg;
        }
    }

    internal class _1872E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                string s = Console.ReadLine()!;

                var ds = new SpecialStructure(a, s);

                var q = int.Parse(Console.ReadLine()!);

                var ans = new List<int>(q);

                for(int j=0; j<q; j++)
                {
                    a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                    if (a[0]==1)
                    {
                        ds.FlipBitString(a[1], a[2]);
                    }
                    else
                    {
                        var ans1 = a[1] switch
                        {
                            0 => ds.xor0sum,
                            1 => ds.xor1sum,
                            _ => 0
                        };

                        ans.Add(ans1);
                    }
                }


                Console.WriteLine(string.Join(' ',ans));
            }
        }
    }
}
