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

            if (decimal.TryParse(input, out decimal Input))
            {
                entry.Id = IdIncrementation();
                entry.Amount = Input;
                Console.WriteLine("Insert description: ");
                entry.Name = Console.ReadLine();
                budget.Add(entry);
            }
            else
            {
                Console.WriteLine("Invalid value. Press any button to continue.");
                Console.ReadKey();
            }

            return entry.Amount;
        }
        public decimal IncomeAction()
        {
            BudgetEntry entry = new BudgetEntry();
            entry.Type = ActionType.Income;
            Console.WriteLine("\nInsert amount: ");
            string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal Input))
                {
                    entry.Id = IdIncrementation();
                    entry.Amount = Input;
                    Console.WriteLine("Insert description: ");
                    entry.Name = Console.ReadLine();
                    budget.Add(entry);
                }
                else
                {
                Console.WriteLine("Invalid value. Press any button to continue.");
                Console.ReadKey();
                }

            return entry.Amount;
        }
        public void EditAction()
        {
            Console.WriteLine("\nEnter ID of entry, which you would like to edit:");
            AllEntries();
            var id = int.TryParse(Console.ReadLine(), out int Id);
            Console.WriteLine("Insert new amount: (press enter to skip)");
            string input = Console.ReadLine();
            if (input != "" && decimal.TryParse(input, out decimal Input) && budget.Any(x => x.Id == Id))
            {
                budget.Find(x => x.Id == Id).Amount = Input;
            }
            else
            {
                Console.WriteLine("Invalid value. Press any button to continue.");
                Console.ReadKey();
            }

            Console.WriteLine("Insert new description: (press enter to skip)");
            string description = Console.ReadLine();
            if(description != "")
            {
                budget.Find(x => x.Id == Id).Name = description;
            }
        }
        public void DeleteAction()
        {
            Console.WriteLine("\nEnter ID of entry, which you would like to delete:");
            AllEntries();
            var id = int.TryParse(Console.ReadLine(), out int Id);
            if(budget.Any(x => x.Id == Id) && id)
            {
                budget.RemoveAll(x => x.Id == Id);
            }
            else
            {
                Console.WriteLine("Invalid value. Press any button to continue.");
                Console.ReadKey();
            }
        }
        public decimal CurrentBalance(decimal balance)
        {
            foreach (var entry in budget)
            {
                if (entry.Type == ActionType.Income)
                {
                    balance += entry.Amount;
                }
                else
                {
                    balance -= entry.Amount;
                }
            }

            return balance;
        }

        public int IdIncrementation()
        {
            return budget.Any() ? budget.Max(x => x.Id) + 1 : 1;
        }

        public void AllEntries()
        {
            Console.WriteLine();
            foreach (var entry in budget)
            {
                Console.WriteLine($"{entry.Id}. {entry.Name}, {entry.Amount}, {entry.Type}");
            }
        }
    }
}