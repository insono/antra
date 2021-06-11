using System;

namespace Exercise7
{
    class Program
    {
        public class Atm
        {
            public int balance = 1000;
            public void CheckBalance()
            {
                Console.WriteLine("Balance is: " + balance);
            }
            public void WithdrawCash()
            {
                Console.WriteLine("Enter amount to withdraw: ");
                int amt = Convert.ToInt32(Console.ReadLine());
                balance -= amt;
            }
            public void DepositCash()
            {
                Console.WriteLine("Enter amount to deposit: ");
                int amt = Convert.ToInt32(Console.ReadLine());
                balance += amt;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your pin number\n");

            Console.WriteLine("Welcome to atm services");
            Atm theAtm = new Atm();
            int choice = 0;
            while (true)
            {
                Console.WriteLine("1. Check balance\n2.Withdraw cash\n3.Deposit cash\n4.Quit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4)
                    break;
                switch(choice)
                {
                    case 1:
                        theAtm.CheckBalance();
                        break;
                    case 2:
                        theAtm.WithdrawCash();
                        break;
                    case 3:
                        theAtm.DepositCash();
                        break;
                    default:
                        theAtm.CheckBalance();
                        break;
                }
            }
            
        }
    }
}
