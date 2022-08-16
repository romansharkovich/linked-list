using System;
using System.Diagnostics;

namespace LinkedList
{
    class LinkedList
    {
        public Node headItem;
        public void Print()
        {
            Node temp = headItem;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public void Push(int data)
        {
            Node temp = new Node(data);
            temp.next = headItem;
            headItem = temp;
        }
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

            /*Debug.Assert(false);*/
            return 0;
        }
    }
}
