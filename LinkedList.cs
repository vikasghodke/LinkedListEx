using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DataStructureExample
{
    public class LinkedList<T>
    {

        public Node<T> head;
        // private Node<T> tail;

        public LinkedList()
        {
            head = null;
        }


        //Insert Data
        public void insert(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (head == null)
            {

                head = newnode;


            }


        }

        //Insert FirstNode
        public void InsertFirst(T data)
        {
            Node<T> newnode = new Node<T>(data);
            newnode.next = head;
            head = newnode;


        }

        //Insert Last Data
        public void InertLast(T data)
        {
            Node<T> newnode = new Node<T>(data);

            if (head == null)
            {
                head = newnode;
                return;
            }
            Node<T> lastnode = head;
            while (lastnode.next != null)
            {
                lastnode = lastnode.next;
            }
            lastnode.next = newnode;


        }

        public void InsertMid(T data)
        {
            Node<T> temp = head;
            Node<T> newnode = new Node<T>(data);
            Console.WriteLine("Enter a Position");
            int index = Convert.ToInt32(Console.ReadLine());
            while ((index - 2) > 0)
            {
                temp = temp.next;
                index--;
            }
            newnode.next = temp.next;
            temp.next = newnode;




        }
        //Remove FIrst Element
        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.next;
            }
            else
            {
                Console.WriteLine("List in Empty");
            }
        }

        public void RemoveLast()
        {
            Node<T> temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
        public void RemoveMid()
        {
            Node<T> temp = head;
            Console.WriteLine("Enter position to delete");
            int index = Convert.ToInt32(Console.ReadLine());

            while (index - 2 > 0)
            {
                temp = temp.next;
                index--;
            }
            temp.next.next = null;
        }

        //Display Data
        public void Display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + "  ");
                temp = temp.next;
            }
            Console.WriteLine("End");

        }







    }


}

