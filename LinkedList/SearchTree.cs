using System.Collections.Generic;

namespace LinkedListSpace
{
    internal class SearchTree
    {
        private TreeNode HeadItem { get; set; }
        public List<int> BinarySearchTree()
        {
            return BinarySearchTree(HeadItem);
        }

        public TreeNode NewNode(int data)
        {
            TreeNode node = new TreeNode(data);

            node.Left = null;
            node.Right = null;

            return node;
        }

        public void Delete(int data) { 
            HeadItem = DeleteNode(data, HeadItem); 
        }

        // function to delete an existing key in a binary search tree
        TreeNode DeleteNode(int data, TreeNode HeadItem)
        {
            if (HeadItem == null)
                return HeadItem;

            if (data < HeadItem.data)
                HeadItem.Left = DeleteNode(data, HeadItem.Left);
            else if (data > HeadItem.data)
                HeadItem.Right = DeleteNode(data, HeadItem.Right);
            else { 
                if (HeadItem.Left == null)
                    return HeadItem.Right;
                else if (HeadItem.Right == null)
                    return HeadItem.Left;

                HeadItem.data = minValue(HeadItem.Right);
                HeadItem.Right = DeleteNode(HeadItem.data, HeadItem.Right);
            }
            return HeadItem;
        }

        int minValue(TreeNode item)
        {
            int minv = item.data;
            while (item.Left != null) {
                minv = item.Left.data;
                item = item.Left;
            }
            return minv;
        }

        // Insert
        public void Insert(int data) {
            if (HeadItem == null) HeadItem = new TreeNode(data);
            else InsertNode(data, HeadItem);
        }

        // function to insert key in a binary search tree
        private void InsertNode(int data, TreeNode HeadItem)
        {
            if (data < HeadItem.data)
            {
                if (HeadItem.Left == null) HeadItem.Left = new TreeNode(data);
                else InsertNode(data, HeadItem.Left);
            }

            else if (data > HeadItem.data)
            {
                if (HeadItem.Right == null)
                    HeadItem.Right = new TreeNode(data);
                else
                    InsertNode(data, HeadItem.Right);
            }
        }

        // Preorder traversal without recursion 
        public List<int> BinarySearchTree(TreeNode node)
        {
            List<int> resultList = new List<int>();
            TreeNode current, pre;

            if (node == null)
                return resultList;

            current = node; 

            while (current != null)
            {
                if (node.Left == null) {
                    Console.Write(current.data + " ");
                    resultList.Add(current.data);
                    current = current.Right;
                } else {
                    pre = current.Left;
                    while (pre.Right != null && pre.Right != current) {
                        pre = pre.Right;
                    }
 
                    if (pre.Right == null) {
                        pre.Right = current;
                        current = current.Left;
                    } else {
                        pre.Right = null;
                        Console.Write(current.data + " ");
                        resultList.Add(current.data);
                        current.Right = node;
                    }
                }
            }
            return resultList;
        }

        public void BinarySearchDefault()
        {
            BinarySearchDefault(HeadItem);
        }

        // standart preorder traversal binary search
        public void BinarySearchDefault(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.data + " ");
                BinarySearchDefault(node.Left);
                BinarySearchDefault(node.Right);
            }
        }
    }
}
