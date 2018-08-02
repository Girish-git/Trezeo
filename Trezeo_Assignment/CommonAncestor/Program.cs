using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonAncestor
{
    public class TreeNode
    {
        // The value held by the node
        public int Value { get; }
        // A link to the parent node in the tree
        public TreeNode Parent { get; }
        // A link to the left child node in the tree
        public TreeNode Left { get; }
        // A link to the right child node in the tree
        public TreeNode Right { get; }
    }

    class BST
    {
        // Create Tree Methods

        TreeNode root;

        //Search Common Ancestor
        public static TreeNode LowestCommonAncestor(TreeNode node, TreeNode n1, TreeNode n2)
        {
            if (node == null)
                return null;

            if (node.Value > n1.Value && node.Value > n2.Value)
                return LowestCommonAncestor(node.Left, n1, n2);

            if (node.Value < n1.Value && node.Value < n2.Value)
                return LowestCommonAncestor(node.Right, n1, n2);
            return node;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Initialize tree 


            Console.ReadLine();
        }
    }
}
