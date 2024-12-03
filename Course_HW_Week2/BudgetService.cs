using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Course_HW_Week2
{
    public class BudgetService
    {
        private List<BudgetEntry> budget = new List<BudgetEntry>();

        public decimal ExpenseAction()
        {
            BudgetEntry entry = new BudgetEntry();
            entry.Type = ActionType.Expense;
            Console.WriteLine("\nInsert amount: ");
            string input = Console.ReadLine();

            if (BudgetValidator.DataValidation(input))
            {
                entry.Amount = decimal.Parse(input);
            }
            else
            {
                goto exc;
            }

            Console.WriteLine("Insert description: ");
            entry.Name = Console.ReadLine();
            budget.Add(entry);
        exc: Console.WriteLine("Invalid value");
            return entry.Amount;

        }
        public decimal IncomeAction()
        {
            BudgetEntry entry = new BudgetEntry();
            entry.Type = ActionType.Income;
            Console.WriteLine("\nInsert amount: ");
            string input = Console.ReadLine();

                if (BudgetValidator.DataValidation(input))
                {
                    entry.Amount = decimal.Parse(input);
                }
                else
                {
                    goto exc;
                }

            Console.WriteLine("Insert description: ");
            entry.Name = Console.ReadLine();
            budget.Add(entry);
        exc: Console.WriteLine("Invalid value");
            return entry.Amount;

        }
        public void AllOperations()
        {
            Console.WriteLine();
            foreach (var entry in budget)
            {
                Console.WriteLine($"{entry.Name}, {entry.Amount}, {entry.Type}");
            }
        }
    }
}
