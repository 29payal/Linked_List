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
            
            //Delete first element
            Console.WriteLine("###################################################");
            DeleteFirstElement deleteFirstElement = new DeleteFirstElement();
            Console.WriteLine("Before delete element the list is :");
            deleteFirstElement.AddEnd(56);
            deleteFirstElement.AddEnd(30);
            deleteFirstElement.AddEnd(70);
            deleteFirstElement.Display();
            
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("After delete the element the list is :");
            deleteFirstElement.DeleteFirstNode();
            deleteFirstElement.Display();
            Console.ReadLine();
        }
    }
}
