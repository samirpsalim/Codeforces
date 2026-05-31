namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1504B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!;
                var b = Console.ReadLine()!;

                var hasStarted = false;
                var checksdiff= true;
                var diff = 0;

                for(int j =n-1; j>=0; j--)
                {
                    if(!hasStarted)
                    {
                        if (a[j]!= b[j])
                        {
                            hasStarted = true;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if ((checksdiff && a[j] != b[j]) || (!checksdiff && a[j] == b[j]))
                    {
                        if (a[j] == '0')
                        {
                            diff--;
                        }
                        else
                        {
                            diff++;
                        }
                    }
                    else
                    {
                        if(diff!=0) break;
                        checksdiff = !checksdiff;
                        if (a[j] == '0')
                        {
                            diff--;
                        }
                        else
                        {
                            diff++;
                        }
                    }
                    
                }

                Console.WriteLine(diff==0? "YES" : "NO");
            }
        }
    }
}
