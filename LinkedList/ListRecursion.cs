namespace LinkedListSpace
{
    internal class ListRecursion : LinkedList
    {
        public Node Reverse(Node headItem)
        {
            if (headItem == null ||
                headItem.next == null)
                return headItem;

            var rest = Reverse(headItem.next);
            headItem.next.next = headItem;

            headItem.next = null;

            return rest;
        }
    }
}