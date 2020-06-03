using System;

namespace Bank
{
    public class LinkList<T>
    {
        public Node head; // head of list 

        /* Linked list Node*/
        public class Node
        {
            
            public Node next;
            public int accountNumber;
            public string userName;
            public int balance;
            
            public Node(int accountNumber, string userName, int balance)
            {
                this.accountNumber = accountNumber;
                this.userName = userName;
                this.balance = balance;
                next = null;
            }
        }
        
        public void Add(int accountNumber, string userName, int balance)
        {
            //Allocate the Node & Put in the data
            Node newNode = new Node(accountNumber, userName, balance);

            //Make next of new Node as head 
            newNode.next = head;

            //Move the head to point to new Node 
            head = newNode;
        }

        /// <summary>
        /// Display Data of All Users
        /// </summary>
        public void PrintList()
        {
            Node firstNode = head;
            while (firstNode != null)
            {
                Console.Write("Account Number : " + firstNode.accountNumber + "\n" +
                              "User Name      : " + firstNode.userName + "\n" +
                              "Account Balance: " + firstNode.balance + "\n\n");
                firstNode = firstNode.next;
            }
        }
        public void Search(int accountNumber)
        {
            Node firstNode = head;
            while (firstNode != null)
            {
                if (firstNode.accountNumber == accountNumber)
                {
                    Console.Write("Account Number : " + firstNode.accountNumber + "\n" +
                                  "User Name      : " + firstNode.userName + "\n" +
                                  "Account Balance: " + firstNode.balance + "\n\n");    
                }
                firstNode = firstNode.next;
            }
        }

        public void Deposit(int accountNumber, int amount)
        {
            Node firstNode = head;
            while (firstNode != null)
            {
                if (firstNode.accountNumber == accountNumber)
                {
                    firstNode.balance = firstNode.balance + amount;
                    Console.Write("Account Number : " + firstNode.accountNumber + "\n" +
                                  "User Name      : " + firstNode.userName + "\n" +
                                  "Account Balance: " + firstNode.balance + "\n\n");
                }
                firstNode = firstNode.next;
            }
        }

    }
}