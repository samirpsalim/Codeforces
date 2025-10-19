public class LeetCode4 {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int left = 0;
        int right = nums1.Length - 1;
        int partition1 = left + (right - left) / 2;

        throw new NotImplementedException();
    }
}