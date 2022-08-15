using System;
using System.Diagnostics;

namespace LinkedList
{
    internal class LinkedList : ListRecursion
    {
        public int GetMth(int index)
        {
            Node current = headItem;
            int count = 0;
            while (current != null)
            {
                if (count == index)
                    return current.data;
                count++;
                current = current.next;
            }

            Debug.Assert(false);
            return 0;
        }
    }
}
