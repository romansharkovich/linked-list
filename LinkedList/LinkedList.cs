using System;
using System.Diagnostics;

namespace LinkedListSpace
{
    class LinkedList
    {
        public Node<int> headItem;
        public void Print()
        {
            var temp = headItem;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public void Push(int data)
        {
            var temp = new Node<int>(data);
            temp.next = headItem;
            headItem = temp;
        }
        
        public int GetMth(int index)
        {
            var current = headItem;
            var count = 0;
            while (current != null)
            {
                if (count == index)
                    return current.data;
                count++;
                current = current.next;
            }
            return 0;
        }
    }
}
