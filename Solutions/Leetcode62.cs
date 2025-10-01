public class Leetcode62 {
    public int UniquePaths(int m, int n)
    {
        if (m < n) return UniquePaths(n, m);

        int res = 1;

        for (int i = 0; i < m - 1; ++i)
        {
            res *= (n + i);
        }
        for (int i = 0; i < m - 1; ++i)
        {
            res /= (1 + i);
        }
        return res;        
    }
}