using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces
{
    internal class CF2123B
    {
        internal bool IsInLastK(int n, int j, int k, int[] a)
        {
            if (k > 1) return true;

            if (a[j - 1] != a.Max()) return false;

            return true;
        }
    }
}
