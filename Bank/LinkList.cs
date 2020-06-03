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

        /// <summary>
        /// To Search User Details to Check for Balance.
        /// </summary>
        /// <param name="accountNumber"></param>
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

        /// <summary>
        /// To Deposit Amount to Users Account
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>
        public void Deposit(int accountNumber, int amount)
        {
            Node firstNode = head;
            while (firstNode != null)
            {
                //search till account number matches
                if (firstNode.accountNumber == accountNumber)
                {
                    //add new amount to previous balance
                    firstNode.balance = firstNode.balance + amount;
                    Console.Write("Account Number : " + firstNode.accountNumber + "\n" +
                                  "User Name      : " + firstNode.userName + "\n" +
                                  "Account Balance: " + firstNode.balance + "\n\n");
                }
                firstNode = firstNode.next;
                if (firstNode == null)
                {
                    Console.WriteLine("Wrong Account Number..Enter Right Account Number..!!");
                }
            }   
        }
        
        /// <summary>
        /// To Withdrow Balance from Users Account
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>
        public void Withdraw(int accountNumber, int amount)
        {
            Node firstNode = head;
            while (firstNode != null)
            {
                //Search till Account number matches
                if (firstNode.accountNumber == accountNumber)
                {
                    //check if Balance Sufficient
                    if (firstNode.balance > amount)
                    {
                        //subtract Amount from previous Balance
                        firstNode.balance = firstNode.balance - amount;
                        Console.Write("Account Number : " + firstNode.accountNumber + "\n" +
                                  "User Name      : " + firstNode.userName + "\n" +
                                  "Account Balance: " + firstNode.balance + "\n\n");
                    }
                    //check if Balance Insufficient
                    if (firstNode.balance < amount )
                        Console.WriteLine("Sorry..Balance is Insufficient.");
                }
                firstNode = firstNode.next;
                if (firstNode == null)
                {
                    Console.WriteLine("Wrong Account Number..Enter Right Account Number..!!");
                }
            }
        }

    }
}