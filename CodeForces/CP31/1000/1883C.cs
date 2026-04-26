namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1883C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            Span<int> mods = stackalloc int[4];

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0],arr[1]);

                if(k==2)
                {
                    var ans = Console.ReadLine()!.Split(' ').Select(int.Parse).Any(ai=> ai%2==0) ? 0 :1;
                    Console.WriteLine(ans);
                    continue;
                }

                if(k==3 || k==5)
                {
                    var maxmod = Console.ReadLine()!.Split(' ').Select(int.Parse).Max(ai => ai % k == 0? k : ai % k);

                    Console.WriteLine(k-maxmod);
                    continue;
                }

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                mods.Fill(0);

                foreach(var ai in a)
                {
                    mods[ai % 4]++;

                    if (mods[0] > 0 || mods[2] > 1)
                        break;
                }

                if(mods[0]>0 || mods[2]>1)
                {
                    Console.WriteLine(0);
                    continue;
                }

                if (mods[3]>0 || (mods[2]>0 && mods[1]>0))
                {
                    Console.WriteLine(1);
                    continue;
                }

                if (mods[2]>0 || mods[1]>1)
                {
                    Console.WriteLine(2);
                    continue;
                }

                if (mods[1]>1)
                {
                    Console.WriteLine(3);
                }

            }
        }
    }
}
