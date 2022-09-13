using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class Node
    {
       
        // instance

        public int data;
        public Node next;

        //Constructor
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}