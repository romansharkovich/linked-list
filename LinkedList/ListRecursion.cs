namespace LinkedList
{
    class ListRecursion
    {
        public Node headItem;

        public Node reverse(Node headItem)
        {
            if (headItem == null ||
                headItem.next == null)
                return headItem;

            Node rest = reverse(headItem.next);
            headItem.next.next = headItem;

            headItem.next = null;

            return rest;
        }

        public void print()
        {
            Node temp = headItem;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public void push(int data)
        {
            Node temp = new Node(data);
            temp.next = headItem;
            headItem = temp;
        }
    }
}