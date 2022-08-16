namespace LinkedList
{
    internal class PreorderTraversal : LinkedList
    {
        public void TraversalPreorder()
        {
            TraversalPreorder(headItem);
        }

        // Preorder traversal without recursion 
        public void TraversalPreorder(Node node)
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

        public void Preorder()
        {
            Preorder(headItem);
        }

        // standart preorder traversal 
        public void Preorder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.data + " ");
                Preorder(node.left);
                Preorder(node.right);
            }
        }
    }
}
