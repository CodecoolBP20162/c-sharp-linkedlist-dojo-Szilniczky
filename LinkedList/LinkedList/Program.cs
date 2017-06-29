using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.addElement(1);
            sll.addElement(2);
            sll.addElement(3);
            sll.printOutElements();
            Console.ReadLine();
        }
    }
}
