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
