namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1886C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            var ans = "";

            for (int i = 0; i < t; i++)
            {
                var s = new LinkedList<char>(Console.ReadLine()!);
                var p = long.Parse(Console.ReadLine()!);
                var remnode = s.First;

                while (p>s.Count)
                {
                    p -= s.Count;
                    while (remnode.Next is not null && remnode.Value <= remnode.Next.Value)
                    { 
                        remnode = remnode.Next;
                    }

                    if(remnode.Previous is null)
                    {
                        remnode = remnode.Next;
                        s.Remove(remnode.Previous);
                    }
                    else
                    {
                        remnode = remnode.Previous;
                        s.Remove(remnode.Next);
                    }
                }

                ans +=GetAtIndex(s,p - 1);
            }

            Console.WriteLine(ans);
        }

        private static string GetAtIndex(LinkedList<char> s, long v)
        {
            var node =s.First;
            for(int i = 0;i <= v;i++)
            {
                if (i == v) return node.Value.ToString();
                node = node.Next;
            }

            return "";
        }
    }
}
