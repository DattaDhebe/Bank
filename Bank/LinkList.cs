using System;
using System.Drawing;

namespace Bank
{
    public class LinkList<T>
    {
        int count = 0;
        public Node head; // head of list 

        /* Linked list Node*/
        public class Node
        {
            
            public Node next;
            public object userDetails;
            
            public Node(object userDetails)
            {
                this.userDetails = userDetails;
                next = null;
            }
        }

        public void Add(object userDetails)
        {
            /* 1 & 2: Allocate the Node & 
                    Put in the data*/
            Node new_node = new Node(userDetails);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
            count++;
        }

        public void PrintList()
        {
            Node firstNode = head;
            while (firstNode != null)
            {
                Console.Write(firstNode.userDetails + " ");
                firstNode = firstNode.next;
            }
        }
    }
}