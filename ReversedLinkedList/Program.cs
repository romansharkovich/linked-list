using System;

namespace ReversedLinkedList
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // mth elemnt to m
            LinkedList linkedList = new LinkedList();

            linkedList.push(4);
            linkedList.push(3);
            linkedList.push(2);
            linkedList.push(1);
            linkedList.push(0);

            Console.WriteLine("Element at index 3 is " + linkedList.GetMth(3));
            Console.WriteLine("Element at index 4 is " + linkedList.GetMth(4));

            // recursion
            var recursion = new ListRecursion();

            recursion.push(13);
            recursion.push(23);
            recursion.push(35);
            recursion.push(53);
            recursion.push(54);

            Console.WriteLine("linked list before: ");
            recursion.print();
            recursion.headItem = recursion.reverse(recursion.headItem);
            Console.WriteLine("linked list after: ");
            recursion.print();
        }
    }
}