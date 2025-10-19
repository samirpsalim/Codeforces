public class LeetCode3 {
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> lastSeen = new();
        var count = 0;
        var maxcount = 0;
        var startCount = -1;
        for (int i = 0; i < s.Length; ++i)
        {
            if (!lastSeen.ContainsKey(s[i]))
            {
                count += 1;
                if (count > maxcount) maxcount = count;
            }
            else if (lastSeen[s[i]] <= startCount)
            {
                count += 1;
                if (count > maxcount) maxcount = count;
            }
            else
            {
                startCount = lastSeen[s[i]];
                count = i - startCount;
            }
            lastSeen[s[i]] = i;
        }
        return maxcount;
    }
}