/**
 * Definition for a binary tree node.
 */

//  private class TreeNode {
//      public int val;
//      public TreeNode left;
//      public TreeNode right;
//      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
//          this.val = val;
//          this.left = left;
//          this.right = right;
//      }
//  }

public class Leetcode104
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null) return 0;
        if (root.left is null && root.right is null) return 1;
        return DepthTracker(root, 1);
    }

    public int DepthTracker(TreeNode root, int curDepth)
    {
        if (root.left is null && root.right is null) return curDepth;
        if (root.left is null) return DepthTracker(root.right, curDepth + 1);
        if (root.right is null) return DepthTracker(root.left, curDepth + 1);
        return int.Max(DepthTracker(root.left, curDepth + 1), DepthTracker(root.right, curDepth + 1));
    }
}