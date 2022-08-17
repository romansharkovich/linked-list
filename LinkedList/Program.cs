using System;

namespace LinkedListSpace
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // mth elemnt to m
            var linkedList = new LinkedList();

            linkedList.Push(4);
            linkedList.Push(3);
            linkedList.Push(2);
            linkedList.Push(1);
            linkedList.Push(0);

            Console.WriteLine("Element at index 3 is " + linkedList.GetMth(3));
            Console.WriteLine("Element at index 4 is " + linkedList.GetMth(4));

            // recursion
            var recursion = new ListRecursion();

            recursion.Push(13);
            recursion.Push(23);
            recursion.Push(35);
            recursion.Push(53);
            recursion.Push(54);

            Console.WriteLine("linked list before: ");
            recursion.Print();
            recursion.headItem = recursion.Reverse(recursion.headItem);
            Console.WriteLine("linked list after: ");
            recursion.Print();

            // traversal preorder binary search tree without recursion
            var tree = new SearchTree();
            tree.headItem = new Node(0);
            tree.headItem.left = new Node(1);
            tree.headItem.right = new Node(2);
            tree.headItem.left.left = new Node(3);
            tree.headItem.left.right = new Node(4);
            tree.headItem.right.left = new Node(5);
            tree.headItem.right.right = new Node(6);
            tree.headItem.left.left.left = new Node(7);
            tree.headItem.left.left.right = new Node(8);
            tree.headItem.left.right.left = new Node(9);
            tree.headItem.left.right.right = new Node(10);
            
            tree.BinarySearchTree();
            Console.WriteLine("");
            
            tree.BinarySearchDefault();
        }
    }
}