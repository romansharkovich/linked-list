using System;
using System.Collections.Generic;
namespace LinkedListSpace
{
    public class NodeForSearch
    {
        public int data { get; set; }
        public NodeForSearch left { get; set; }
        public NodeForSearch right { get; set; }

        public NodeForSearch(int item)
        {
            data = item;
            left = right = null;
        }
    }
}
