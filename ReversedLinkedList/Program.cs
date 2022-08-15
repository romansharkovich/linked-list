using System;

namespace ReversedLinkedList
{
    public class Program
    {
        public static void Main(String[] args)
        {
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