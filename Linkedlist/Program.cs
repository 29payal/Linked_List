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
                        //insert 4th element
          
            Insert insert = new Insert();
            Console.WriteLine("Elements before insert the 4th element :");
            insert.AddEnd(56);
            insert.AddEnd(30);
            insert.AddEnd(70);
            insert.Display();
            
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Elements after insert the 4th element in 3rd position :");
            insert.InsertInBetween(40, 3);
            insert.Display();

            Console.ReadLine();
        }
    }
}
