namespace LinkedListSpace
{
    internal class ListReverse : LinkedList
    {
        // reverse list using recursion
        public Node<int> ReverseRecursion(Node<int> headItem)
        {
            if (headItem == null ||
                headItem.next == null)
                return headItem;

            var reverse = ReverseRecursion(headItem.next);
            headItem.next.next = headItem;

            headItem.next = null;

            return reverse;
        }

        // reverse list without recursion
        public void ReverseWithoutRecursion()
        {
            Node<int> current = headItem, prev = null, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            headItem = prev;
        }

        // reverse immmutable
        public ListReverse ReverseImmutable()
        {
            var listReverse = new ListReverse();
            Node<int> current = headItem;
            while (current != null)
            {
                listReverse.Push(current.data);
                current = current.next;
            }
            return listReverse;
        }
    }
}