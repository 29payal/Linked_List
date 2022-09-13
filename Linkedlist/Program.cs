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

            //NODE LINKED LIST// reverse order
            Console.WriteLine("#############################################");
            CustomlinkedList customlinkedList = new CustomlinkedList();
            Console.WriteLine("Elements in reverse order :");
            customlinkedList.AddFirst(70);
            customlinkedList.AddFirst(30);
            customlinkedList.AddFirst(56);
            customlinkedList.Display();

            //moving order
            Console.WriteLine("##################################################");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            Console.WriteLine("Print the elements of the list in moving order :");
            customLinkedList.AddEnd(56);
            customLinkedList.AddEnd(30);
            customLinkedList.AddEnd(70);
            customLinkedList.Display();

            //insert
            Console.WriteLine("###############################################");
            InsertElement insertElement = new InsertElement();
            Console.WriteLine("Elements before insert");
            insertElement.AddEnd(56);
            insertElement.AddEnd(70);
            insertElement.Display();
            Console.WriteLine("___________________________________");

            Console.WriteLine("Elements after insert");
            insertElement.InsertInBetween(30, 2);
            insertElement.Display();

            //Delete first element
            Console.WriteLine("###################################################");
            DeleteFirstElement deleteFirstElement = new DeleteFirstElement();
            Console.WriteLine("Before deleting first element in the list :");
            deleteFirstElement.AddEnd(56);
            deleteFirstElement.AddEnd(30);
            deleteFirstElement.AddEnd(70);
            deleteFirstElement.Display();
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("After deleting first element in the list :");
            deleteFirstElement.DeleteFirstNode();
            deleteFirstElement.Display();

            //Delete last element
            Console.WriteLine("##################################################");
            DeleteLastElement deleteLastElement = new DeleteLastElement();
            Console.WriteLine("Before deleting last element in the list ");
            deleteLastElement.AddEnd(56);
            deleteLastElement.AddEnd(30);
            deleteLastElement.AddEnd(70);
            deleteLastElement.Display();
            Console.WriteLine("______________________________________________");
            Console.WriteLine("After deleting last element in the list ");
            deleteLastElement.DeleteLastNode();
            deleteLastElement.Display();

            Console.ReadLine();
        }
    }
}
