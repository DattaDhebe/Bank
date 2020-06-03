using System;

namespace Bank
{
    public class LinkList<T>
    {
        public Node head; // head of list 

        /* Linked list Node*/
        public class Node
        {
            public string userName;
            public int balance;
            
            public Node next;
            internal string data;
            private UserRegistration userRegistration;

            public Node(UserRegistration userRegistration)
            {
                this.userRegistration = userRegistration;
            }

            //public Node(string d) { data = d; next = null; }

        }

        public void Add(UserRegistration userRegistration)
        {
            /* 1 & 2: Allocate the Node & 
                    Put in the data*/
            Node new_node = new Node(userRegistration);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }

        internal void PrintList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.data + " ");
                tnode = tnode.next;
            }
        }
    }
}