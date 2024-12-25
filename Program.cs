using System.Text;

namespace Home_Work_14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            // 1 Bank 
            bool exit = true;

            while (exit)
            {

                Console.Write("Введіть назву свого банку: ");
                string bankName = Console.ReadLine();


                Account accountUa = new Account(bankName, 100.00m);

                Console.Write("Введіть своє ім'я: ");
                string userName = Console.ReadLine();

                HelloUser(userName,bankName);

                bool exitOperation = true;

                while (exitOperation)
                {
                    Console.WriteLine("Виберіть операцію :\n1 - Перевірити баланас \n2 - Зняти кошти \n3 - Додати кошти \n4 - Вихід");
                    int inputOperation = Convert.ToInt32(Console.ReadLine());



                    switch (inputOperation)
                    {
                        case 1:
                            accountUa.CheckBalance();
                            break;

                        case 2:
                            Console.Write("\nВведіть суму для зняття коштів: ");
                            decimal inputWithdrawal = Convert.ToDecimal(Console.ReadLine());
                            accountUa.Withdrawal(inputWithdrawal);
                            break;
                        case 3:
                            Console.Write("\nВведіть суму для додання коштів: ");
                            decimal inputDeposit = Convert.ToDecimal(Console.ReadLine());
                            accountUa.Deposit(inputDeposit);
                            break;
                        case 4:
                            exit = false;
                            exitOperation = false;
                            break;
                        default:
                            Console.WriteLine("Не правельна вибрана операція");
                            break;

                    }
                }
  
            }

            // 2 Bank

            Account accountPl = new Account("mBankPl", 234.23m);


            accountPl.CheckBalance();

            accountPl.Withdrawal(50);

            accountPl.Deposit(70);

        }

        static void HelloUser(string name, string bankName)
        {
            Console.WriteLine($"\nВітаю {name} в банку {bankName}\n");
        }
    }
}
