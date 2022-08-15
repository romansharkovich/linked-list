namespace LinkedList
{
    internal class PreorderTraversal : ListRecursion
    {
        public void traversalPreorder()
        {
            traversalPreorder(headItem);
        }

        // Preorder traversal without recursion 
        public void traversalPreorder(Node node)
        {
            while (node != null)
            {
                if (node.left == null) {
                    Console.Write(node.data + " ");
                    node = node.right;
                } else {
                    Node current = node.left;
                    while (current.right != null &&
                           current.right != node) {
                        current = current.right;
                    }
 
                    if (current.right == node) {
                        current.right = null;
                        node = node.right;
                    } else {
                        Console.Write(node.data + " ");
                        current.right = node;
                        node = node.left;
                    }
                }
            }
        }

        public void preorder()
        {
            preorder(headItem);
        }

        // standart preorder traversal 
        public void preorder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.data + " ");
                preorder(node.left);
                preorder(node.right);
            }
        }
    }
}
