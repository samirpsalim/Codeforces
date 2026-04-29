namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1659A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, r, b) = (arr[0], arr[1], arr[2]);

                int leftb = b, leftr = r;
                int redperblue = (int)Math.Ceiling((decimal)r / (b+1));

                var result = new string(Enumerable.Repeat('R', redperblue).ToArray());
                leftr -= redperblue;

                for(int j=0; j<b; j++)
                {
                    redperblue = (int)Math.Ceiling((decimal)leftr / leftb);
                    result += string.Concat("B",new string(Enumerable.Repeat('R', redperblue).ToArray()));
                    leftr -= redperblue;
                    leftb--;
                }

                Console.WriteLine(result);
            }
        }
    }
}
