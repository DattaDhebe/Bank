using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int choice = 0, amount, accountNumber;
            Console.WriteLine("Welcome TO State Bank..!!");
            Console.Write("1. Withdrow\n2. Deposit\n3. Check Balance\n4. Add User\n");
            Console.WriteLine("\nSelect Your Choice : ");
            userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            Console.WriteLine(choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Amount To Be Withdrow : ");
                    userInput = Console.ReadLine();
                    amount = Convert.ToInt32(userInput);
                    withdrow(amount);
                    break;
                case 2:
                    Console.WriteLine("Enter Amount To Be Deposit : ");
                    userInput = Console.ReadLine();
                    amount = Convert.ToInt32(userInput);
                    Deposit(amount);
                    break;
                case 3:
                    Console.WriteLine("Enter Account Number To Search : ");
                    userInput = Console.ReadLine();
                    accountNumber = Convert.ToInt32(userInput);
                    CheckBalance(accountNumber);
                    break;
                case 4: 
                    AddUser();
                    break;
            }


        }

        private static void AddUser()
        {
            string userName, userInput;
            int amount;
            Console.WriteLine("Enter User Name : ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter Opening Amount : ");
            userInput = Console.ReadLine();
            amount = Convert.ToInt32(userInput);

            LinkList<UserRegistration> list = new LinkList<UserRegistration>();
            list.Add(new UserRegistration(userName, amount));
            list.PrintList();
            
        }

        private static void CheckBalance(int accountNumber)
        {
            throw new NotImplementedException();
        }

        private static void Deposit(int amount)
        {
            throw new NotImplementedException();
        }

        private static void withdrow(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
