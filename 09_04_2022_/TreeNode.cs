using System;

namespace _09_04_2022_
{
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode parent;

        public TreeNode(int x)
        {
            value = x;
        }

        public static void printTree(TreeNode n)
        {
            if (n == null) return;
            Console.WriteLine(n.value);
            printTree(n.left, 0, true);
            printTree(n.right, 0, false);
        }

        private static void printTree(TreeNode n, int level, bool isLeft)
        {
            if (n == null) return;
            for (int i = 0; i < level; ++i) Console.Write("  ");
            if (isLeft)
                Console.WriteLine("/- " + n.value);
            else
                Console.WriteLine("\\- " + n.value);
            printTree(n.left, level + 1, true);
            printTree(n.right, level + 1, false);
        }

        public override string ToString()
        {
            return value.ToString(); 
        }
    }
}
