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
            var reverse = new ListReverse();

            reverse.Push(13);
            reverse.Push(23);
            reverse.Push(35);
            reverse.Push(53);
            reverse.Push(54);

            Console.WriteLine("linked list before: ");
            reverse.Print();
            reverse.ReverseWithoutRecursion();
            Console.WriteLine("linked list after reverse: ");
            reverse.Print();
            reverse.headItem = reverse.ReverseRecursion(reverse.headItem);
            Console.WriteLine("linked list after reverse recursion: ");
            reverse.Print();
            var getReverseList = reverse.ReverseImmutable();
            Console.WriteLine("linked list after reverse immutable: ");
            getReverseList.Print();
            
            // traversal preorder binary search tree without recursion
            var tree = new SearchTree();
            tree.headItem = new NodeForSearch(0);
            tree.headItem.left = new NodeForSearch(1);
            tree.headItem.right = new NodeForSearch(2);
            tree.headItem.left.left = new NodeForSearch(3);
            tree.headItem.left.right = new NodeForSearch(4);
            tree.headItem.right.left = new NodeForSearch(5);
            tree.headItem.right.right = new NodeForSearch(6);
            tree.headItem.left.left.left = new NodeForSearch(7);
            tree.headItem.left.left.right = new NodeForSearch(8);
            tree.headItem.left.right.left = new NodeForSearch(9);
            tree.headItem.left.right.right = new NodeForSearch(10);
            
            tree.BinarySearchTree();
            Console.WriteLine("");
            
            tree.BinarySearchDefault();
        }
    }
}