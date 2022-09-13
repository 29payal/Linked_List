using Linkedlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class CustomlinkedList
    {
        Node head;
    public void Display()
    {
        Node temp = this.head;
        if (temp == null)
        {
            Console.WriteLine("Linked list is empty");
        }
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }
    public void AddFirst(int newData)
    {
        Node newnode = new Node(newData);
        newnode.next = head;
        this.head = newnode;
    }
}
}