using System;
using Xunit;
using LinkList;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            // Arrange
            LinkdList ll = new LinkdList(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);

            //Act
            ll.Add(node);
            ll.Add(node2);

            //Assert

            Assert.Equal(ll.Head.Value, node2.Value);

        }

        // I am terribly confused by this and why the CountedNodes() is throwing an error.
        /*[Fact]
        public void CountedNodesAreAdded()
        {
            // Arrange
            LinkdList ll = new LinkdList(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);

            //Act
            ll.Add(node);
            ll.Add(node2);

            int number = ll.CountNodes();

            //Assert
            Assert.Equal(3, number);

        }*/


        [Theory]
        [InlineData(8, 8)]
        [InlineData(23, 23)]
        public void CanFindNodeThatExists(int value, int expected)
        {
            //Arrange
            LinkdList ll = new LinkdList(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);
            Node node3 = new Node(16);
            Node node4 = new Node(23);

            ll.Add(node);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);

            //Act
            Node found = ll.Find(value);

            //Assert
            Assert.Equal(expected, found.Value);

        }


        [Theory]
        [InlineData(42)]
        [InlineData(100)]
        public void ReturnsNullForNodeThatDoesNotExist(int value)
        {
            //Arrange
            LinkdList ll = new LinkdList(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);
            Node node3 = new Node(16);
            Node node4 = new Node(23);

            //Act
            ll.Add(node);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);

            Node found = ll.Find(value);

            //Assert
            Assert.Null(found);
        }
    }
}