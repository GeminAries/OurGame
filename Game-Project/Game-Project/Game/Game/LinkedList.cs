using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Node
    {
        public Node next;
        public Object obj;
        public int index;
    }

    public class LinkedList
    {

        //create node member "head"
        private Node head = null;


        public LinkedList()
        {
            this.head = null;
        }


        /***************Define functionality****************/


        //add new node to head
        public void addToHead(Object data)
        {
            if (this.head == null)
            {
                this.head = new Node();
                this.head.obj = data;
                this.head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.obj = data;
                toAdd.next = this.head;
                this.head = toAdd;
            }
        }


        //add new node to tail
        public void addToTail(Object data)
        {
            if(this.head == null)
            {
                this.head = new Node();
                this.head.obj = data;
                this.head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.obj = data;
                Node current = this.head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = toAdd;
            }
        }

        //remove a node from the head
        public void removeFromHead()
        { 
                if (this.head != null)
                {
                    Node current = this.head.next;
                    this.head.obj = null;
                    this.head = null;
                    this.head = current;
                }
            }
        
        //remove a node from the tail
        public void removeFromTail()
        {
            if(this.head != null)
            {
                Node current = this.head.next;
                while (this.head.next.next != null)  //while the next node AFTER the next node is not null....
                {
                    current = current.next;  // Move me down the list.
                } // Now I'm at the 2nd to last node.
                current.next.obj = null;  //Delete the object contained in the node to my right (The last node)
                current.next.next = null; //Delete the "next" pointer of the node to my right (The last node)
            }
        }
    }

    public class ItemList : LinkedList
    {
        //I want this to be a dynamic doubly-linked list that will hold item objects.
    }

    public class BuffList : LinkedList
    {
        //I want this to be a singly linked list of Buff objects.
    }

}

