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
             //Node linked list //moving order
      
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
