using System.Runtime.InteropServices;

namespace Leetcode.CodeForces.CF4
{
    internal record class Envelope(int W, int H,int Order, int Length, int NextW,int NextH);
    internal class _4D
    {
        private static Dictionary<(int, int), Envelope?> _processResult = new();

        static void Solve(string[] args)
        {
            var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var n = input[0];
            var w = input[1];
            var h = input[2];

            List<(int,int,int)>  envelopes= new();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                if (input[0] > w && input[1] > h)
                {
                    envelopes.Add((input[0], input[1], i+1));
                }
            }

            if (envelopes.Count == 0) Console.WriteLine(0);
            else
            {
                envelopes.Sort();
                var result = new List<int>();
                var curenv = Process(CollectionsMarshal.AsSpan(envelopes), w, h);
                while(curenv.NextW!=0 && curenv.NextH!=0)
                {
                    result.Add(curenv.Order);
                    _processResult.TryGetValue((curenv.NextW, curenv.NextH), out curenv);
                }
                Console.WriteLine(result.Count);
                Console.WriteLine(string.Join(" ", result));
            }
        }

        private static Envelope Process(Span<(int, int, int)> envelopes, int w, int h)
        {
            if (_processResult.TryGetValue((w, h), out var curval)) return curval;

            var curlength = 0;
            var curorder = 0;
            Envelope next = null;

            int i = 0;
            foreach (var envelope in envelopes)
            {
                i++;
                if(envelope.Item1>w && envelope.Item2 >h)
                {
                    if(!_processResult.TryGetValue((w,h), out var trialnext))
                    {
                        trialnext = Process(envelopes.Slice(i), envelope.Item1, envelope.Item2);
                    }
                    if (trialnext is not null)
                    {
                        if(trialnext.Length+1> curlength)
                        {
                            curlength = trialnext.Length+1;
                            curorder = envelope.Item3;
                            next = trialnext;
                        }
                    }
                }
            }
            var ans = new Envelope(w,h,curorder, curlength, next?.W??0, next?.H??0);
            _processResult.Add((w, h), ans);
            return ans;
        }
    }
}
