using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseholdAccounts account1 = new HouseholdAccounts();
            account1.AddExpense(new DateTime(2001, 1, 1), "just a test");
            account1.AddExpense(new DateTime(2005, 1, 1), "just a test 2");
            account1.AddExpense(new DateTime(2009, 1, 1), "just a test 3");
            //account1.Display();
            //account1.DisplayCategoryBetweenDates("", new DateTime(2001, 1, 1), new DateTime(2006, 1, 1));
            //account1.searchDescription("2");
            //account1.modExpense(1);
            account1.deleteExpense(2);
            account1.Display();

        }
    }
}
