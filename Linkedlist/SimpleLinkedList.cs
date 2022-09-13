using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class SimpleLinkedList
    {
        public void Add()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);

            foreach (int  value in list)
            {
                Console.WriteLine(value);
            }

        }
    }
}