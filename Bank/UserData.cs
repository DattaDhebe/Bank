

namespace Bank
{
    public class UserData 
    {
        int accountNumber, balance;
        string userName;

        public UserData(int accountNumber, string userName, int balance)
        {
            this.accountNumber = accountNumber;
            this.userName = userName;
            this.balance = balance;
        }

    }
}


