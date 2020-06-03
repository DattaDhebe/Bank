using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class UserRegistration
    {
        String name;
        int balance;

        public UserRegistration(String name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public int getBalance()
        {
            return balance;
        }
        public String getName()
        {
            return name;
        }

    }
}
