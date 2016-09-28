using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLengthAndAdd()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add("string");
            list.Add(true);

            Assert.AreEqual(3, list.Length());
        }

        [TestMethod]
        public void TestAddAtFirstPosition()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.AddAt(4, 0);
            Assert.AreEqual(4, list.EllementAt(0));
        }

        [TestMethod]
        public void TestAddAtLastPosition()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.AddAt(4, 2);
            Assert.AreEqual(4, list.EllementAt(2));
        }
        [TestMethod]
        public void TestAddAtTheMiddle()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.AddAt(4, 1);
            Assert.AreEqual(4, list.EllementAt(1));
        }

    }
}
