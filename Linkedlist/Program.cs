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
            
            //insert
           
            InsertElement insertElement = new InsertElement();
            Console.WriteLine("Elements before insert");
            insertElement.AddEnd(56);
            insertElement.AddEnd(70);
            insertElement.Display();
            Console.WriteLine("___________________________________");

            Console.WriteLine("Elements after insert");
            insertElement.InsertInBetween(30, 2);
            insertElement.Display();
            Console.ReadLine();
        }
    }
}
