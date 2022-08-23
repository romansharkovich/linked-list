namespace LinkedListSpace
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }

        public Node(T item)
        {
            data = item;
            next = null;
        }
    }
}
