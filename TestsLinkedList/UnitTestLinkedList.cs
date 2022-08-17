using LinkedListSpace;

namespace TestsLinkedList
{
    [TestClass]
    public class UnitTestLinkedList
    {
        [TestMethod]
        public void FindTheMthElement()
        {
            // Arrange
            var linkedList = new LinkedList();

            linkedList.Push(4);
            linkedList.Push(3);
            linkedList.Push(2);
            linkedList.Push(1);
            linkedList.Push(0);

            // Action
            var third = linkedList.GetMth(3);
            var fourth = linkedList.GetMth(4);

            // Assert
            Assert.AreEqual(3, third);
            Assert.AreEqual(4, fourth);
            Assert.IsNotNull(third);
            Assert.IsNotNull(fourth);
            Assert.AreNotEqual(fourth, third);
        }

        [TestMethod]
        public void ReverseLinkedList()
        {
            // Arrange
            var recursion = new ListRecursion();

            recursion.Push(13);
            recursion.Push(23);
            recursion.Push(35);
            recursion.Push(53);
            recursion.Push(54);

            // Assert
            Assert.AreEqual(54, recursion.headItem.data);
            
            // Action
            recursion.headItem = recursion.Reverse(recursion.headItem);

            // Assert
            Assert.AreEqual(13, recursion.headItem.data);
            Assert.AreEqual(23, recursion.headItem.next.data);
        }

        [TestMethod]
        public void BinarySearchTree()
        {
            // Arrange
            var tree = new SearchTree();
            tree.headItem = new Node(0);
            tree.headItem.left = new Node(1);
            tree.headItem.right = new Node(2);
            tree.headItem.left.left = new Node(3);
            tree.headItem.left.right = new Node(4);
            tree.headItem.right.left = new Node(5);
            tree.headItem.right.right = new Node(6);
            tree.headItem.left.left.left = new Node(7);
            tree.headItem.left.left.right = new Node(8);
            tree.headItem.left.right.left = new Node(9);
            tree.headItem.left.right.right = new Node(10);

            // Action
            tree.BinarySearchTree();

            // Assert
            Assert.AreEqual(0, tree.headItem.data);
            Assert.AreEqual(1, tree.headItem.left.data);
            Assert.AreEqual(2, tree.headItem.right.data);
            Assert.AreEqual(3, tree.headItem.left.left.data);
        }
    }
}