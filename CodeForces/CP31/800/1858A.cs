namespace Leetcode.CodeForces.CP31._800
{
    internal class _1858A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var buttons = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                if (buttons[0]> buttons[1])
                {
                    Console.WriteLine("First");
                    continue;
                }
                if (buttons[0] < buttons[1])
                {
                    Console.WriteLine("Second");
                    continue;
                }
                Console.WriteLine(buttons[2]%2==1 ? "First" : "Second");
            }
        }
    }
}
