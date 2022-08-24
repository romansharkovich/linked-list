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

            // Action
            var resultList = tree.BinarySearchTree();
            for (var i = 10; i < 100; i += 10)
                tree.Insert(i);

            // Assert
            var a = 10;
            foreach (var i in resultList)
                Assert.AreNotEqual(a+10, i);

            // Action
            for (var i = 10; i < 100; i += 20)
                tree.Delete(i);

            // Assert
            a = 10;
            foreach (var i in resultList)
                Assert.AreNotEqual(a + 10, i);
        }
    }
}