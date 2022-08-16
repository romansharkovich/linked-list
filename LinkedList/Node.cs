namespace LinkedList
{
    public class Node
    {
        public int data { get; set; }
        public Node next { get; set; }
        // binaary tree
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int item)
        {
            data = item;
            next = null;
            left = right = null;
        }
    }
}
