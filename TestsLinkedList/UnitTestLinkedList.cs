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
            var reverse = new ListReverse();

            reverse.Push(13);
            reverse.Push(23);
            reverse.Push(35);
            reverse.Push(53);
            reverse.Push(54);

            // Assert
            Assert.AreEqual(54, reverse.headItem.data);

            // Action
            reverse.headItem = reverse.ReverseRecursion(reverse.headItem);

            // Assert
            Assert.AreEqual(13, reverse.headItem.data);
            Assert.AreEqual(23, reverse.headItem.next.data);

            //Action 
            reverse.ReverseWithoutRecursion();

            // Assert
            Assert.AreEqual(54, reverse.headItem.data);
            Assert.AreEqual(53, reverse.headItem.next.data);

            //Action 
            var reverseImmutable = reverse.ReverseImmutable();

            // Assert
            Assert.AreEqual(13, reverseImmutable.headItem.data);
            Assert.AreEqual(23, reverseImmutable.headItem.next.data);
        }

        [TestMethod]
        public void BinarySearchTree()
        {
            // Arrange
            var tree = new SearchTree();
            tree.headItem = new NodeForSearch(0);
            tree.headItem.left = new NodeForSearch(1);
            tree.headItem.right = new NodeForSearch(2);
            tree.headItem.left.left = new NodeForSearch(3);
            tree.headItem.left.right = new NodeForSearch(4);
            tree.headItem.right.left = new NodeForSearch(5);
            tree.headItem.right.right = new NodeForSearch(6);
            tree.headItem.left.left.left = new NodeForSearch(7);
            tree.headItem.left.left.right = new NodeForSearch(8);
            tree.headItem.left.right.left = new NodeForSearch(9);
            tree.headItem.left.right.right = new NodeForSearch(10);

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