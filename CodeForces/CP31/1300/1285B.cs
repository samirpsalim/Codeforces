namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1285B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(Answer(a)?"YES":"NO");
            }
        }

        private static bool Answer(int[] a)
        {
            long sum = a[0];

            if(sum <=0) return false;

            foreach (var ai in a.Skip(1))
            {
                sum += ai;
                if (sum <=0) return false;
            }

            sum = a[a.Length-1];

            if (sum <= 0) return false;

            foreach (var ai in a.SkipLast(1).Reverse())
            {
                sum += ai;
                if (sum <= 0) return false;
            }

            return true;
        }
    }
}
