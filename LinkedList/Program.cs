using System;

namespace LinkedList
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // mth elemnt to m
            LinkedList linkedList = new LinkedList();

            linkedList.push(4);
            linkedList.push(3);
            linkedList.push(2);
            linkedList.push(1);
            linkedList.push(0);

            Console.WriteLine("Element at index 3 is " + linkedList.GetMth(3));
            Console.WriteLine("Element at index 4 is " + linkedList.GetMth(4));

            // recursion
            var recursion = new ListRecursion();

            recursion.push(13);
            recursion.push(23);
            recursion.push(35);
            recursion.push(53);
            recursion.push(54);

            Console.WriteLine("linked list before: ");
            recursion.print();
            recursion.headItem = recursion.reverse(recursion.headItem);
            Console.WriteLine("linked list after: ");
            recursion.print();

            // traversal preorder
            PreorderTraversal tree = new PreorderTraversal();
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
            tree.traversalPreorder();
            Console.WriteLine("");
            tree.preorder();
        }
    }
}