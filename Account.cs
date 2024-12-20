namespace Home_Work_14._1
{
    public class Account
    {
        private string bankAccount;

        private decimal balance;

        private string name;

        public string BankAccount
        {
            get
            {
                return bankAccount;
            }
            set
            {
                bankAccount = value;
            }
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public Account(string bankAccount, decimal balance)
        {
            this.balance = balance;
            this.bankAccount = bankAccount;
        }

        public void HelloUser(string name)
        {
            Console.WriteLine($"\nВітаю {name} в банку {bankAccount}\n");
        }


        public decimal Withdrawal(decimal amount)
        {
            bool verification = true;
            decimal result = 0;
            while (verification)
            {
                if (amount > balance)
                {
                    Console.WriteLine("Заданна сума перевищує баланс на вашому рахунку");
                    break;
                }
                result = balance - amount;

                balance = result;
                verification = false;

            }
            Console.WriteLine($"Коштів на вашому рахунку : {balance:F2}\n");
            return result;
        }

        public decimal Deposit(decimal amount)
        {
            decimal result = amount + balance;
            balance = result;

            Console.WriteLine($"Коштів на вашому рахунку : {balance:F2}\n");
            return result;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"\nНа вашому рахунку: {balance}");
        }




    }
}
