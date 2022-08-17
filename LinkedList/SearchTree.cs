﻿namespace LinkedListSpace
{
    internal class SearchTree : LinkedList
    {
        public void BinarySearchTree()
        {
            BinarySearchTree(headItem);
        }

        // Preorder traversal without recursion 
        public void BinarySearchTree(Node node)
        {
            while (node != null)
            {
                if (node.left == null) {
                    Console.Write(node.data + " ");
                    node = node.right;
                } else {
                    var current = node.left;
                    while (current.right != null &&
                           current.right != node) {
                        current = current.right;
                    }
 
                    if (current.right == node) {
                        current.right = null;
                        node = node.right;
                    } else {
                        Console.Write(node.data + " ");
                        current.right = node;
                        node = node.left;
                    }
                }
            }
        }

        public void BinarySearchDefault()
        {
            BinarySearchDefault(headItem);
        }

        // standart preorder traversal binary search
        public void BinarySearchDefault(Node node)
        {
            if (node != null)
            {
                Console.Write(node.data + " ");
                BinarySearchDefault(node.left);
                BinarySearchDefault(node.right);
            }
        }
    }
}