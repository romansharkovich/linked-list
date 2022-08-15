namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        // binaary tree
        public Node left, right;
        public Node(int item)
        {
            data = item;
            next = null;
            left = right = null;
        }
    }
}
