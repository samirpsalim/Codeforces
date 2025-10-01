

/**
 * Definition for a binary tree node.
 */
public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }

public class Leetcode101 {
    public bool IsSymmetric(TreeNode root) {
        if (root.left is null && root.right is null) return true;
        if (root.left is null || root.right is null) return false;
        return AreMirror(root.left, root.right);
    }

    private bool AreMirror(TreeNode left, TreeNode right)
    {
        if (left is null && right is null) return true;
        if (left is null || right is null) return false;
        if (left.val != right.val) return false;
        return AreMirror(left.left, right.right) && AreMirror(left.right, right.left);
        throw new NotImplementedException();
    }
}