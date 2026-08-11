using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo
{
    internal class EncadList
    {
        public Node Head{ get; set; }
        public Node Tail{ get; set; }
        public int Length{ get; set; }
        
        public void Insert(string data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
                Tail = newNode;
            }
            Length++;
        }

        public void Remove(string data)
        {
            if (Head == null || Tail == null)
            {
                return;
            }
            else
            {
                Tail = Tail.Prev;
                Tail.Next = null;
            }
        }
    }
}
