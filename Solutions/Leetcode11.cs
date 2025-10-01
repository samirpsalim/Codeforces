public class LeetCode11 {
    public int MaxArea(int[] height)
    {
        int maxVol = (height.Length - 1) * int.Max(height[0], height[height.Length - 1]);
        int left = 0;
        int right = height.Length - 1;
        for (int i = 1; i < height.Length - 1; ++i)
        {

        }
        throw new NotImplementedException();
    }
}