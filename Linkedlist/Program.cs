﻿using System;
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
            //NODE LINKED LIST//Reverse order
            Console.WriteLine("#############################################");
            CustomlinkedList customlinkedList = new CustomlinkedList();
            Console.WriteLine("Elements in reverse order :");
            customlinkedList.AddFirst(70);
            customlinkedList.AddFirst(30);
            customlinkedList.AddFirst(56);
            customlinkedList.Display();
            

            Console.ReadLine();
        }
    }
}
