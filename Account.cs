namespace Home_Work_14._1
{
    public class Account
    {
        private string bankAccount;

        private decimal balance;

        private string name;

        public string BankAccount
        {
            get => bankAccount;
            set
            {

                bankAccount = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Назва банку не можу бети пустою");
            }
        }

        public decimal Balance
        {
            get => balance;

            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Баланс не може бути менше 0");
                }
                else
                {
                    balance = value;
                }
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
            Balance = balance;
            BankAccount = bankAccount;
        }



        public decimal Withdrawal(decimal amount)
        {
            bool verification = true;
            decimal result = 0;
            while (verification)
            {
                if (amount > Balance)
                {
                    Console.WriteLine("Заданна сума перевищує баланс на вашому рахунку");
                    break;
                }
                result = Balance - amount;

                Balance = result;
                verification = false;

            }
            Console.WriteLine($"Коштів на вашому рахунку : {Balance:F2}\n");
            return result;
        }

        public decimal Deposit(decimal amount)
        {
            decimal result = amount + Balance;
            Balance = result;

            Console.WriteLine($"Коштів на вашому рахунку : {Balance:F2}\n");
            return result;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"\nНа вашому рахунку: {Balance:F2}");
        }




    }
}
