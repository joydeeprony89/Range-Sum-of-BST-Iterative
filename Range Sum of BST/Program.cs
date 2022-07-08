using System;
using System.Collections.Generic;

namespace Range_Sum_of_BST
{
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(10);
      root.left = new TreeNode(5);
      root.left.left = new TreeNode(3);
      root.left.right = new TreeNode(7);
      root.right = new TreeNode(15);
      root.right.right = new TreeNode(18);

      Solution s = new Solution();
      var answer = s.RangeSumBST(root, 7, 15);
      Console.WriteLine(answer);
    }
  }

  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  public class Solution
  {
    public int RangeSumBST(TreeNode root, int low, int high)
    {
      int sum = 0;
      Queue<TreeNode> q = new Queue<TreeNode>();
      q.Enqueue(root);
      while (q.Count > 0)
      {
        var node = q.Dequeue();
        if (node.val >= low && node.val <= high) sum += node.val;
        if(node.val > low && node.left != null)
        {
          q.Enqueue(node.left);
        }
        if(node.val < high && node.right != null)
        {
          q.Enqueue(node.right);
        }
      }

      return sum;
    }
  }
}
