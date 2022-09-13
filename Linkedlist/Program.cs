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
            //Search
            Searchvalue list = new Searchvalue();
            list.AddEnd(43);
           
            list.Search(56);
            list.Display();
            Console.ReadLine();
        }
    }
}
