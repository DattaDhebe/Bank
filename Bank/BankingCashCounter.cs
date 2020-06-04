using System;


namespace Bank
{
    class BankingCashCounter
    {
        public static LinkList<UserData> list = new LinkList<UserData>();
        public static int accountNumber = 1;
        static void Main(string[] args)
        {
            string userInput;
            int choice = 0, amount;
            while (true)
            {
                Console.WriteLine("\nWelcome To State Bank..!!");
                Console.Write("\n1. Withdraw\n2. Deposit\n3. Check Balance" +
                              "\n4. Check User Details\n5. Add User\n6. Delete User" +
                              "\n7. Display All User Deatails\n8. Delete First Record" +
                              "\n9. Delete Last Record\n10. Exit");
                
                Console.WriteLine("\nSelect Your Choice : ");
                userInput = Console.ReadLine();
                choice = Convert.ToInt32(userInput);
                Console.WriteLine(choice);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Account Number : ");
                        userInput = Console.ReadLine();
                        accountNumber = Convert.ToInt32(userInput);
                        Console.WriteLine("Enter Amount To Be Withdrow : ");
                        userInput = Console.ReadLine();
                        amount = Convert.ToInt32(userInput);
                        Withdraw(accountNumber, amount);
                        break;

                    case 2:
                        Console.WriteLine("Enter Account Number : ");
                        userInput = Console.ReadLine();
                        accountNumber = Convert.ToInt32(userInput);
                        Console.WriteLine("Enter Amount To Be Deposit : ");
                        userInput = Console.ReadLine();
                        amount = Convert.ToInt32(userInput);
                        Deposit(accountNumber, amount);
                        break;

                    case 3:
                        Console.WriteLine("Enter Account Number To Search : ");
                        userInput = Console.ReadLine();
                        accountNumber = Convert.ToInt32(userInput);
                        CheckBalance(accountNumber);
                        break;

                    case 4:
                        Console.WriteLine("Enter Account Number To Search : ");
                        userInput = Console.ReadLine();
                        accountNumber = Convert.ToInt32(userInput);
                        CheckBalance(accountNumber);
                        break;

                    case 5:
                        AddUser(accountNumber);
                        accountNumber = accountNumber + 1;
                        Console.WriteLine("Data Are Successfully Added.");
                        break;

                    case 6:
                        Console.WriteLine("Enter Account Number To be Deleted :");
                        userInput = Console.ReadLine();
                        accountNumber = Convert.ToInt32(userInput);
                        Delete(accountNumber);
                        Console.WriteLine("Data Are Successfully Deleted.");
                        break;

                    case 7:
                        Console.WriteLine("\n  ~ User Details ~ ");
                        list.PrintList();
                        break;

                    case 8:
                        DeleteFirst();
                        Console.WriteLine("Data Are Successfully Deleted.");
                        break;

                    case 9:
                        DeleteLast();
                        Console.WriteLine("Data Are Successfully Deleted.");
                        break;

                    case 10:
                        break;

                    default:
                        Console.WriteLine("Please Select Right Choice..");
                        break;
                        
                }
                if (choice == 10)
                {
                    Console.WriteLine("Thank You For Banking With Us..!!");
                    break;
                }
            }
        }

        private static void Withdraw(int accountNumber, int amount)
        {
            list.Withdraw(accountNumber, amount);
        }
        private static void Deposit(int accountNumber, int amount)
        {
            list.Deposit(accountNumber, amount);
        }

        private static void CheckBalance(int accountNumber)
        {
            list.Search(accountNumber);
        }

        private static void AddUser(int accountNumber)
        {
            string userName, userInput;
            int amount;

            Console.WriteLine("~ New User Registration ~ ");

            Console.WriteLine("Enter User Name : ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter Amount : ");
            userInput = Console.ReadLine();
            amount = Convert.ToInt32(userInput);
            
            // Add new User Details to Node
            list.Add(accountNumber, userName, amount);
        }

        private static void Delete(int accountNumber)
        {
            list.Delete(accountNumber);
        }

        private static void DeleteFirst()
        {
            list.DeleteFirst();
        }

        private static void DeleteLast()
        {
            list.DeleteLast();
        }

    }
}
