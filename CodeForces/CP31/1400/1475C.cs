namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1475C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);


            for(int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (a,b,k) = (arr[0], arr[1],arr[2]);

                var boys = new int[a];
                var girls = new int[b];

                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                foreach(var ai in arr)
                {
                    boys[ai-1] += 1;
                }

                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                foreach (var bi in arr)
                {
                    girls[bi - 1] += 1;
                }

                var ans = (long)k * (k + 1);

                foreach(var ai in boys)
                {
                    ans -=(long)ai*ai;
                }

                foreach(var bi in girls)
                {
                    ans -=(long)bi*bi;
                }

                Console.WriteLine(ans/2);
            }
        }
    }
}
