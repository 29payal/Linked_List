using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SIMPLE LINKED LIST
            SimpleLinkedList simpleLinkedList = new SimpleLinkedList();
            Console.WriteLine("Print the elements of simple linked list :");
            simpleLinkedList.Add();

            //NODE LINKED LIST
            Console.WriteLine("#############################################");
            CustomlinkedList customlinkedList = new CustomlinkedList();
            Console.WriteLine("Elements in reverse order :");
            customlinkedList.AddFirst(70);
            customlinkedList.AddFirst(30);
            customlinkedList.AddFirst(56);
            customlinkedList.Display();

            Console.WriteLine("##################################################");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            Console.WriteLine("Print the elements of the list in moving order :");
            customLinkedList.AddEnd(56);
            customLinkedList.AddEnd(30);
            customLinkedList.AddEnd(70);
            customLinkedList.Display();
           
            Console.ReadLine();
        }
    }
}
