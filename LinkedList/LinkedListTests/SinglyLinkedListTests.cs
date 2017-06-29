using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    [TestClass()]
    public class SinglyLinkedListTests
    {
        [TestMethod()]
        public void addElementTest()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addElement(1);
            Assert.IsNotNull(sll);
        }

        [TestMethod()]
        public void removeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void printOutElementsTest()
        {
            Assert.Fail();
        }
    }
}