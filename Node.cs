using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureExample
{
    public class Node<T>
    {
        public T Data;
        public Node<T> next;
        public T position;



        public Node(T data)
        {
            this.Data = data;
            this.next = null;


        }
    }
}
