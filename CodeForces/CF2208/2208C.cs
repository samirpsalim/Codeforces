namespace Leetcode.CodeForces.CF2208
{
    record ProblemTask(float c,float p);

    internal class _2208C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var tasks = new ProblemTask[n];

                for (int j = 0; j < n; j++)
                {
                    var input =Console.ReadLine()!.Split(' ');
                    tasks[n-1-j] =new ProblemTask(float.Parse(input[0]), float.Parse(input[1]));
                }

                float cj = tasks[0].c;
                foreach (var task in tasks.Skip(1))
                {
                    if(100*task.c>=task.p*cj)
                    {
                        cj = task.c + (1 - (task.p / 100)) * cj;
                    }
                }
                Console.WriteLine(cj);
            }
        }
    }
}
