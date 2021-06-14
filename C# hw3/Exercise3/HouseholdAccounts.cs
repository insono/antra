using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Expense
    {
        public DateTime Date;
        public string Description = "";
        public string Category = "";
        public double Amount = 0.0;
        public Expense(DateTime date, string des, string category, double amt)
        {
            Date = date;
            Description = des;
            Category = category;
            Amount = amt;
        }
        public void Display()
        {
            Console.WriteLine($"Date: {Date.Date.ToShortDateString()}\nDescription: {Description}\nCategory: {Category}\nAmount: {Amount}\n");
        }
    }
    class HouseholdAccounts
    {
        protected List<Expense> Expenses = new List<Expense>();

        public void AddExpense(DateTime date, string des, string category = "", double amt = 0.0) {
            Expense x = new Expense(date, des, category, amt);
            Expenses.Add(x);
        }
        public void Display()
        {
            foreach(Expense x in Expenses)
            {
                x.Display();
            }
        }
        public void DisplayCategoryBetweenDates(string cate, DateTime earlierDate, DateTime laterDate)
        {
            foreach(Expense x in Expenses)
            {
                if (x.Category == cate && (earlierDate < x.Date) && (x.Date < laterDate))
                {
                    x.Display();
                }
            }
        }

        public void searchDescription(string keywords)
        {
            foreach(Expense x in Expenses)
            {
                if (x.Description.Contains(keywords))
                {
                    x.Display();
                }
            }
        }

        public void modExpense(int x)
        {
            Expense toMod = Expenses[x];
            Console.WriteLine("1 to modify date\n2 to modify Description\n3 to modify Category\n4 to modify ammount");
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    Console.WriteLine($"Current date is {toMod.Date.ToShortDateString()}");
                    Console.WriteLine("Enter new Date YYYYMMDD");
                    string input2 = Console.ReadLine();
                    toMod.Date = new DateTime(Convert.ToInt32(input2.Substring(0, 4)), Convert.ToInt32(input2.Substring(4, 2)), Convert.ToInt32(input2.Substring(6, 2)));
                    break;
                case 2:
                    Console.WriteLine($"Current description is: {toMod.Description}");
                    Console.WriteLine("Enter new description: ");
                    input2 = Console.ReadLine();
                    toMod.Description = input2;
                    break;
                case 3:
                    Console.WriteLine($"Current Category is: {toMod.Category}");
                    Console.WriteLine("Enter new category: ");
                    input2 = Console.ReadLine();
                    toMod.Category = input2;
                    break;
                case 4:
                    Console.WriteLine($"Current amount is: {toMod.Amount}");
                    Console.WriteLine("Enter new amount");
                    toMod.Amount = Convert.ToDouble(Console.ReadLine());
                    break;

            }
        }

        public void deleteExpense(int x)
        {
            Console.WriteLine("Deleting this data");
            Expenses[x].Display();
            Expenses.RemoveAt(x);
        }
        public void sortByDate()
        {
            Expenses.Sort((x, y) => x.Date.CompareTo(y.Date));
        }

        public void normalizeDescription()
        {
            foreach(Expense x in Expenses)
            {
                x.Description.ToLower();
                x.Description.Trim(' ');
            }
        }
    }
}
